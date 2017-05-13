using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using YCompany.EPolicyPortal.BusinessModel;

namespace YCompany.EPolicyPortal.ServiceLayer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}