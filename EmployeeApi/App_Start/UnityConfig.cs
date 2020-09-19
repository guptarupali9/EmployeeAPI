using EmployeeApi.BusinessServices.Implementation;
using EmployeeApi.BusinessServices.Interface;
using EmployeeApi.DataServices.Implementation;
using EmployeeApi.DataServices.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace EmployeeApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IAccountBusinessService, AccountBusinessService>();
            container.RegisterType<IAccountDataService, AccountDataService>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}