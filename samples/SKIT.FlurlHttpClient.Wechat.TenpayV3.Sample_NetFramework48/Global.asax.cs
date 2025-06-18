using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private Hangfire.BackgroundJobServer _backgroundJobServer;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutofacConfig.Init();
            _backgroundJobServer = HangfireConfig.Init();
        }

        protected void Application_End()
        {
            _backgroundJobServer?.Dispose();
        }
    }
}
