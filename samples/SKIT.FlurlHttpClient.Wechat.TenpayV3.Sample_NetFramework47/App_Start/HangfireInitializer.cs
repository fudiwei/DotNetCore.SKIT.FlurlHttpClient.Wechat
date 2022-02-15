using System;
using System.Collections.Generic;
using Hangfire;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample
{
    public class HangfireInitializer
    {
        public static BackgroundJobServer Init()
        {
            GlobalConfiguration.Configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseInMemoryStorage();

            var server = new BackgroundJobServer();

            HangfireAspNet.Use(() => new BackgroundJobServer[] { server });

            BackgroundJob.Enqueue<Services.BackgroundJobs.TenpayCertificateRefreshingBackgroundJob>(job => job.ExecuteAsync());
            RecurringJob.AddOrUpdate<Services.BackgroundJobs.TenpayCertificateRefreshingBackgroundJob>(job => job.ExecuteAsync(), Cron.Daily);

            return server;
        }
    }
}
