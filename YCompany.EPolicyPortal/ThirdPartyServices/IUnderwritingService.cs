using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCompany.EPolicyPortal.DataModel;

namespace ThirdPartyServices
{
    public interface IUnderwritingService
    {
        long CalculatePremium(InsurancePolicyModel insurancePolicyModel);
    }
}
