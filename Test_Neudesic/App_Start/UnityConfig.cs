using System.Web.Http;
using Test_Neudesic.Services;
using Unity;
using Unity.WebApi;

namespace Test_Neudesic
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterInstance<IProductService>(new ProductService(new ProductContext()));
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}