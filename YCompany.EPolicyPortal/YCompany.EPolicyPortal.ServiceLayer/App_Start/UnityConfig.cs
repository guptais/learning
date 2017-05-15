using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using YCompany.EPolicyPortal.BusinessModel;

//using Unity.Mvc5;

namespace YCompany.EPolicyPortal.ServiceLayer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();
            //in case of mvc5 web application this is important
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            //in case of WEB API this is important
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}