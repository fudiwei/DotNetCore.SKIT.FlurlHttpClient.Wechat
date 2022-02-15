namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class WebApiApplication : HttpApplication
    {
        private Hangfire.BackgroundJobServer _backgroundJobServer;

        protected void Application_Start()
        {
            // ע�� WebAPI ����
            AreaRegistration.RegisterAllAreas();

            // ע�� WebAPI ����
            GlobalConfiguration.Configure(WebApiConfiguration.Register);

            // ע��ȫ�ֹ�����
            FilterRegistration.RegisterGlobalFilters(GlobalFilters.Filters);

            // ע��·�ɱ�
            RouteRegistration.RegisterRoutes(RouteTable.Routes);

            // ��ʼ�� Autofac ����ע������
            AutofacInitializer.Init();

            // ��ʼ�� Hangfire ��ʱ����
            _backgroundJobServer = HangfireInitializer.Init();
        }

        protected void Application_End()
        {
            _backgroundJobServer?.Dispose();
        }
    }
}
