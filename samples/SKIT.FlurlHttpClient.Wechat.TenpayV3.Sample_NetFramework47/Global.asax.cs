using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class WebApiApplication : HttpApplication
    {
        private Hangfire.BackgroundJobServer _backgroundJobServer;

        protected void Application_Start()
        {
            // 注册 WebAPI 区域
            AreaRegistration.RegisterAllAreas();

            // 注册 WebAPI 配置
            GlobalConfiguration.Configure(WebApiConfiguration.Register);

            // 注册全局过滤器
            FilterRegistration.RegisterGlobalFilters(GlobalFilters.Filters);

            // 注册路由表
            RouteRegistration.RegisterRoutes(RouteTable.Routes);

            // 初始化 Autofac 依赖注入容器
            AutofacInitializer.Init();

            // 初始化 Hangfire 定时任务
            _backgroundJobServer = HangfireInitializer.Init();
        }

        protected void Application_End()
        {
            _backgroundJobServer?.Dispose();
        }
    }
}
