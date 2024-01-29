namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class AutofacInitializer
    {
        public static void Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces().AsSelf();

            builder.RegisterType<Services.HttpClients.Implements.WechatTenpayCertificateManagerFactory>()
                   .As<Services.HttpClients.IWechatTenpayCertificateManagerFactory>()
                   .SingleInstance();
            builder.RegisterType<Services.HttpClients.Implements.WechatTenpayClientFactory>()
                   .As<Services.HttpClients.IWechatTenpayClientFactory>()
                   .SingleInstance();

            builder.RegisterType<Services.BackgroundJobs.TenpayCertificateRefreshingBackgroundJob>()
                   .AsSelf()
                   .InstancePerBackgroundJob();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
