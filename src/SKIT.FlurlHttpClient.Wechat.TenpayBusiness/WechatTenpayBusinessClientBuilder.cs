using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 用于构造 <see cref="WechatTenpayBusinessClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatTenpayBusinessClientBuilder : ICommonClientBuilder<WechatTenpayBusinessClient>
    {
        private readonly WechatTenpayBusinessClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatTenpayBusinessClientBuilder(WechatTenpayBusinessClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatTenpayBusinessClient> ICommonClientBuilder<WechatTenpayBusinessClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatTenpayBusinessClient> ICommonClientBuilder<WechatTenpayBusinessClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatTenpayBusinessClient> ICommonClientBuilder<WechatTenpayBusinessClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatTenpayBusinessClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatTenpayBusinessClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatTenpayBusinessClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatTenpayBusinessClient Build()
        {
            WechatTenpayBusinessClient client = _disposeClient.HasValue
                ? new WechatTenpayBusinessClient(_options, _httpClient, _disposeClient.Value)
                : new WechatTenpayBusinessClient(_options, _httpClient);

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

    partial class WechatTenpayBusinessClientBuilder
    {
        public static WechatTenpayBusinessClientBuilder Create(WechatTenpayBusinessClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatTenpayBusinessClientBuilder(options);
        }
    }
}
