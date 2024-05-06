using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    /// <summary>
    /// 用于构造 <see cref="WechatTenpayGlobalClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatTenpayGlobalClientBuilder : ICommonClientBuilder<WechatTenpayGlobalClient>
    {
        private readonly WechatTenpayGlobalClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatTenpayGlobalClientBuilder(WechatTenpayGlobalClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatTenpayGlobalClient> ICommonClientBuilder<WechatTenpayGlobalClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatTenpayGlobalClient> ICommonClientBuilder<WechatTenpayGlobalClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatTenpayGlobalClient> ICommonClientBuilder<WechatTenpayGlobalClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatTenpayGlobalClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatTenpayGlobalClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatTenpayGlobalClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatTenpayGlobalClient Build()
        {
            WechatTenpayGlobalClient client = _disposeClient.HasValue
                ? new WechatTenpayGlobalClient(_options, _httpClient, _disposeClient.Value)
                : new WechatTenpayGlobalClient(_options, _httpClient);

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

    partial class WechatTenpayGlobalClientBuilder
    {
        public static WechatTenpayGlobalClientBuilder Create(WechatTenpayGlobalClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatTenpayGlobalClientBuilder(options);
        }
    }
}
