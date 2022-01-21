namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public static class WebApiConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "{controller}/{action}",
                defaults: new { }
            );
        }
    }
}
