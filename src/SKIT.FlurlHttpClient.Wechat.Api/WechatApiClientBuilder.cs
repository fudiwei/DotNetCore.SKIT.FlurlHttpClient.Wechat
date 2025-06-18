using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 用于构造 <see cref="WechatApiClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatApiClientBuilder : ICommonClientBuilder<WechatApiClient>
    {
        private readonly WechatApiClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatApiClientBuilder(WechatApiClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatApiClient> ICommonClientBuilder<WechatApiClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatApiClient> ICommonClientBuilder<WechatApiClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatApiClient> ICommonClientBuilder<WechatApiClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatApiClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatApiClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatApiClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatApiClient Build()
        {
            WechatApiClient client = _disposeClient.HasValue
                ? new WechatApiClient(_options, _httpClient, _disposeClient.Value)
                : new WechatApiClient(_options, _httpClient);

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

    partial class WechatApiClientBuilder
    {
        public static WechatApiClientBuilder Create(WechatApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatApiClientBuilder(options);
        }
    }
}
