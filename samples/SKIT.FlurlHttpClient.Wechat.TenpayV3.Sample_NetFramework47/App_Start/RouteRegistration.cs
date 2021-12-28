using System.Web.Mvc;
using System.Web.Routing;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class RouteRegistration
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        }
    }
}
