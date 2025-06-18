using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
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
            services.Configure<Options.TenpayOptions>(Configuration.GetSection(nameof(Options.TenpayOptions)));

            // 注入工厂 HTTP 客户端
            services.AddHttpClient();
            services.AddSingleton<Services.HttpClients.IWechatTenpayCertificateManagerFactory, Services.HttpClients.Implements.WechatTenpayCertificateManagerFactory>();
            services.AddSingleton<Services.HttpClients.IWechatTenpayPublicKeyManagerFactory, Services.HttpClients.Implements.WechatTenpayPublicKeyManagerFactory>();
            services.AddSingleton<Services.HttpClients.IWechatTenpayClientFactory, Services.HttpClients.Implements.WechatTenpayClientFactory>();

            // 注入后台任务
            services.AddHostedService<Services.BackgroundServices.TenpayCertificateRefreshingBackgroundService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
