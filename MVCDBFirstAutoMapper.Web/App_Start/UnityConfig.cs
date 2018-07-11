using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using MVCDBFirstAutoMapper.Business.Interface;
using MVCDBFirstAutoMapper.Business.Implementation;
namespace MVCDBFirstAutoMapper.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //container.RegisterType<IUserService, UserService>();
            //container.RegisterType<IAccountService, AccountService>();

            container.RegisterType<IContactRepository, ContactRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}