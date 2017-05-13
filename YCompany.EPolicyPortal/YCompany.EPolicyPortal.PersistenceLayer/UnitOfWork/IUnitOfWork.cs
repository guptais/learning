using System;
using YCompany.EPolicyPortal.PersistenceLayer.Repository;

namespace YCompany.EPolicyPortal.PersistenceLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
        void Save();
    }
}