using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance
{
    /// <summary>
    /// 用于构造 <see cref="WechatWorkFinanceClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatWorkFinanceClientBuilder : ICommonClientBuilder<WechatWorkFinanceClient>
    {
        private readonly WechatWorkFinanceClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;

        private WechatWorkFinanceClientBuilder(WechatWorkFinanceClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatWorkFinanceClient> ICommonClientBuilder<WechatWorkFinanceClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatWorkFinanceClient> ICommonClientBuilder<WechatWorkFinanceClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            throw new NotSupportedException();
        }

        ICommonClientBuilder<WechatWorkFinanceClient> ICommonClientBuilder<WechatWorkFinanceClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            throw new NotSupportedException();
        }

        public WechatWorkFinanceClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatWorkFinanceClient Build()
        {
            WechatWorkFinanceClient client = new WechatWorkFinanceClient(_options);

            foreach (Action<CommonClientSettings> configure in _configures)
            {
                client.Configure(configure);
            }

            return client;
        }
    }

    partial class WechatWorkFinanceClientBuilder
    {
        public static WechatWorkFinanceClientBuilder Create(WechatWorkFinanceClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatWorkFinanceClientBuilder(options);
        }
    }
}
