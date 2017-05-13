using System;
using System.Collections.Generic;
using System.Linq;
using YCompany.EPolicyPortal.PersistenceLayer.Context;
using YCompany.EPolicyPortal.PersistenceLayer.Repository;

namespace YCompany.EPolicyPortal.PersistenceLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EPolicyPortalContext context = new EPolicyPortalContext();
        
        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        
        /// <summary>
        /// Method to get repository 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IGenericRepository<T> Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)))
            {
                return repositories[typeof (T)] as IGenericRepository<T>;
            }

            IGenericRepository<T> repository = new GenericRepository<T>(context);

            Type repositoryType = typeof (T);
            repositories.Add(repositoryType, repository);
            return repository;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}