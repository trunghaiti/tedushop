﻿using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System.Linq;
using TeduShop.Data.Repository;

namespace TeduShop.Service
{
    public interface IPostService 
    {
        Post Add(Post post);
        void Update(Post post);
        Post Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAlByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChange();
    }
    public class PostService : IPostService
    {
        IPostRepository _postReponsitory;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postReponsitory, IUnitOfWork unitOfWork)
        {
            this._postReponsitory = postReponsitory;
            this._unitOfWork = unitOfWork;
        }

        public Post Add(Post post)
        {
            return _postReponsitory.Add(post);
        }

        public Post Delete(int id)
        {
            return _postReponsitory.Delete(id);
        }

        public IEnumerable<Post> GetAlByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status && x.CategoryID == categoryId,out totalRow, page, pageSize, new string[] { "PostCategory" }).ToList();
        }

        public IEnumerable<Post> GetAll()
        {
            return _postReponsitory.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: select all post by tag
            return _postReponsitory.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postReponsitory.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postReponsitory.Update(post);
        }
    }
}
