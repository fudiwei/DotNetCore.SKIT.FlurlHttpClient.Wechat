using System.Web.Mvc;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
