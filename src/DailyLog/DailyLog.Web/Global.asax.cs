using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DailyLog.Core;
using StructureMap;

namespace DailyLog.Web
{    
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {                        
            AreaRegistration.RegisterAllAreas();

            var container = ConfigureDependencies();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            
        }

        public static IContainer ConfigureDependencies()
        {            
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();                    
                    scan.AssembliesFromApplicationBaseDirectory(assembly => assembly.FullName.Contains("DailyLog"));
                    scan.WithDefaultConventions();
                });                
            });

            return ObjectFactory.Container;
        }
    }
}