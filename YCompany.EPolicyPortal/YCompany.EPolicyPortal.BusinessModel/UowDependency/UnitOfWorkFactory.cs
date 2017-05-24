using YCompany.EPolicyPortal.PersistenceLayer.UnitOfWork;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new UnitOfWork();
        }
    }
}