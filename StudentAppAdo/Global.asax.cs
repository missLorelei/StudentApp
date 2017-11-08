using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StudentAppAdo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/javascripts").Include(
                         "~/Scripts/jquery-1.11.0.js"
                         ));

            bundles.Add(new StyleBundle("~/Bundles/styles").Include(
                        "~/Media/css/bootstrap.css",
                        "~/Media/css/bootstrap-grid.css",
                        "~/Media/css/bootstrap-reboot.css"
            ));

            // enableminimization
            BundleTable.EnableOptimizations = false;
        }
    }
}
