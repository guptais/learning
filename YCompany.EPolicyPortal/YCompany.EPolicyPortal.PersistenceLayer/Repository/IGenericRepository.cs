﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace YCompany.EPolicyPortal.PersistenceLayer.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(object id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        void Delete(TEntity entityToDelete);
        void Delete(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}