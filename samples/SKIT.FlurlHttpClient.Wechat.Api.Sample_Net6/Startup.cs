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

            // ע����������ݼ� `appsettings.json` �ļ���
            services.AddOptions();
            services.Configure<Options.WechatOptions>(Configuration.GetSection(nameof(Options.WechatOptions)));

            // ע��ֲ�ʽ��
            services.AddSingleton<Services.DistributedLock.IDistributedLockFactory, Services.DistributedLock.Implements.DistributedLockFactory>();

            // ע��ִ���
            services.AddSingleton<Services.Repositories.IWechatAccessTokenEntityRepository, Services.Repositories.Implements.WechatAccessTokenEntityRepository>();

            // ע�빤�� HTTP �ͻ���
            services.AddHttpClient();
            services.AddSingleton<Services.HttpClients.IWechatApiHttpClientFactory, Services.HttpClients.Implements.WechatApiHttpClientFactory>();

            // ע���̨����
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
