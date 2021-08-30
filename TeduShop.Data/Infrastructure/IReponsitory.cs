﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public interface IReponsitory<T> where T : class
    {
        //Mark an entity as new
        void Add(T entity);

        //Mark an entity as modified
        void Update(T entity);

        //Mark an entity to be removed
        void Delete(T entity);
        void Delete(int id);
        void Delete(string id);

        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //Get an entity by int id
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index, int size, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
