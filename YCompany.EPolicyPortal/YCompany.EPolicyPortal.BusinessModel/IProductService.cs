using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCompany.EPolicyPortal.DataModel;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public interface IProductService
    {
        IEnumerable<InsurancePolicyModel> ViewAllPolicies();
        InsurancePolicyModel GetPolicy(int id);
        void InsertPolicy(InsurancePolicyModel policyModel);
        void UpdatePolicy(int id);
        void DeletePolicy(int id);
    }
}
