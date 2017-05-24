using System.Web.Mvc;
using YCompany.EPolicyPortal.BusinessModel;

namespace YCompany.EPolicyPortal.ServiceLayer.Controllers
{
    public class ProductUIController : Controller
    {
        private readonly IProductService _productService;

        public ProductUIController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: ProductUI
        public ActionResult Index()
        {
            var model = _productService.ViewAllPolicies();
            return View(model);
        }
    }
}