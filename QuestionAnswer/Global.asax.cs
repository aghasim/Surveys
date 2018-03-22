using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using QuestionAnswer.BLL.Infrastructure;
using QuestionAnswer.Util;

namespace QuestionAnswer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            App_Start.AutoMapperConfig.Initialize();

            NinjectModule webModule = new ServicesWebModule();
            NinjectModule serviceModule = new ServiceModule("DefaultConnection");
            var kernel = new StandardKernel(webModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
