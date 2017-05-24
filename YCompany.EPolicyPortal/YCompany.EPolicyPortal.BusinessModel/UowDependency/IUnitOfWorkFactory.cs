using YCompany.EPolicyPortal.PersistenceLayer.UnitOfWork;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
