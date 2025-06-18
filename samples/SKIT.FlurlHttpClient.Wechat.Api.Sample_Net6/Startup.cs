using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // 注入配置项（内容见 `appsettings.json` 文件）
            services.AddOptions();
            services.Configure<Options.WechatOptions>(Configuration.GetSection(nameof(Options.WechatOptions)));

            // 注入分布式锁
            services.AddSingleton<Services.DistributedLock.IDistributedLockFactory, Services.DistributedLock.Implements.DistributedLockFactory>();

            // 注入仓储类
            services.AddSingleton<Services.Repositories.IWechatAccessTokenEntityRepository, Services.Repositories.Implements.WechatAccessTokenEntityRepository>();

            // 注入工厂 HTTP 客户端
            services.AddHttpClient();
            services.AddSingleton<Services.HttpClients.IWechatApiClientFactory, Services.HttpClients.Implements.WechatApiClientFactory>();

            // 注入后台任务
            services.AddHostedService<Services.BackgroundServices.WechatAccessTokenRefreshingBackgroundService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
