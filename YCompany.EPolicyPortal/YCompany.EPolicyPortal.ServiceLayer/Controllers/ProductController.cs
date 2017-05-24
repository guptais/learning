using System;
using System.Collections.Generic;
using System.Web.Http;
using YCompany.EPolicyPortal.BusinessModel;
using YCompany.EPolicyPortal.DataModel;

namespace YCompany.EPolicyPortal.ServiceLayer.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        public IEnumerable<InsurancePolicyModel> Get()
        {
            return _productService.ViewAllPolicies();
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
