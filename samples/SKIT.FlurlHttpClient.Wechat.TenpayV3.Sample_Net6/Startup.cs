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

            // ע����������ݼ� `appsettings.json` �ļ���
            services.AddOptions();
            services.Configure<Options.TenpayOptions>(Configuration.GetSection(nameof(Options.TenpayOptions)));

            // ע�빤�� HTTP �ͻ���
            services.AddHttpClient();
            services.AddSingleton<Services.HttpClients.IWechatTenpayCertificateManagerFactory, Services.HttpClients.Implements.WechatTenpayCertificateManagerFactory>();
            services.AddSingleton<Services.HttpClients.IWechatTenpayHttpClientFactory, Services.HttpClients.Implements.WechatTenpayHttpClientFactory>();

            // ע���̨����
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
