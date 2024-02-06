using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 用于构造 <see cref="WechatTenpayClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatTenpayClientBuilder : ICommonClientBuilder<WechatTenpayClient>
    {
        private readonly WechatTenpayClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatTenpayClientBuilder(WechatTenpayClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatTenpayClient> ICommonClientBuilder<WechatTenpayClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatTenpayClient> ICommonClientBuilder<WechatTenpayClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatTenpayClient> ICommonClientBuilder<WechatTenpayClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatTenpayClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatTenpayClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatTenpayClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatTenpayClient Build()
        {
            WechatTenpayClient client = _disposeClient.HasValue
                ? new WechatTenpayClient(_options, _httpClient, _disposeClient.Value)
                : new WechatTenpayClient(_options, _httpClient);

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

    partial class WechatTenpayClientBuilder
    {
        public static WechatTenpayClientBuilder Create(WechatTenpayClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatTenpayClientBuilder(options);
        }
    }
}
