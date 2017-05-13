using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCompany.EPolicyPortal.DTO;

namespace YCompany.EPolicyPortal.BusinessModel
{
    public interface IProductService
    {
        IEnumerable<InsurancePolicy> GetAllProducts();
        InsurancePolicy GetPolicy(int id);
        void AddPolicy(InsurancePolicy policy);
    }
}
