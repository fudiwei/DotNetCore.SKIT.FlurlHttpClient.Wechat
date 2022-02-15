namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class FilterRegistration
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
