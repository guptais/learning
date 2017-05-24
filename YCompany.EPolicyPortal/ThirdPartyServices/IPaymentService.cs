using YCompany.EPolicyPortal.DataModel;

namespace ThirdPartyServices
{
    public interface IPaymentService
    {
        bool PayPremium(int amount);
    }
}