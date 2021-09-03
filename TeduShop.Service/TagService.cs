using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repository;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface ITagService
    {
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(int id);
        IEnumerable<Tag> GetAll();
        IEnumerable<Tag> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Tag> GetAllByPostPaging(string post, int page, int pageSize, out int totalRow);
        Tag GetByID(int id);
        void SaveChange();
    }
    public class TagService : ITagService
    {
        ITagRepository _tagRepository;
        IUnitOfWork _unitOfWork;

        public TagService(ITagRepository tagRepository, IUnitOfWork unitOfWork)
        {
            this._tagRepository = tagRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Tag tag)
        {
            _tagRepository.Add(tag);
        }

        public void Delete(int id)
        {
            _tagRepository.Delete(id);
        }

        public IEnumerable<Tag> GetAll()
        {
            return _tagRepository.GetAll();
        }

        public IEnumerable<Tag> GetAllByPostPaging(string post, int page, int pageSize, out int totalRow)
        {
            //return _tagRepository.GetMultiPaging(x => x., out totalRow, page, pageSize);
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Tag GetByID(int id)
        {
            return _tagRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Tag tag)
        {
            _tagRepository.Update(tag);
        }
    }
}
