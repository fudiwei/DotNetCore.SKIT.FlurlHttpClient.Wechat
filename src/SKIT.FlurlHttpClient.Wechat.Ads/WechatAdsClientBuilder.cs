using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    /// <summary>
    /// 用于构造 <see cref="WechatAdsClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatAdsClientBuilder : ICommonClientBuilder<WechatAdsClient>
    {
        private readonly WechatAdsClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatAdsClientBuilder(WechatAdsClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatAdsClient> ICommonClientBuilder<WechatAdsClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatAdsClient> ICommonClientBuilder<WechatAdsClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatAdsClient> ICommonClientBuilder<WechatAdsClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatAdsClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatAdsClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatAdsClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatAdsClient Build()
        {
            WechatAdsClient client = _disposeClient.HasValue
                ? new WechatAdsClient(_options, _httpClient, _disposeClient.Value)
                : new WechatAdsClient(_options, _httpClient);

            foreach (Action<CommonClientSettings> configure in _configures)
            {
                client.Configure(configure);
            }

            foreach (HttpInterceptor interceptor in _interceptors)
            {
                client.Interceptors.Add(interceptor);
            }

            return client;
        }
    }

    partial class WechatAdsClientBuilder
    {
        public static WechatAdsClientBuilder Create(WechatAdsClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatAdsClientBuilder(options);
        }
    }
}
