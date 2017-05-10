using System;
using System.Collections.Generic;
using System.Linq;

namespace YCompany.EPolicyPortal.PersistenceLayer
{
    public class UnitOfWork : IDisposable
    {
        private readonly EPolicyPortalContext context = new EPolicyPortalContext();

        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        /// <summary>
        /// Method to get repository 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public GenericRepository<T> Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)))
            {
                return repositories[typeof (T)] as GenericRepository<T>;
            }
            GenericRepository<T> repo = new GenericRepository<T>(context);
            repositories.Add(typeof(T), repo);
            return repo;
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