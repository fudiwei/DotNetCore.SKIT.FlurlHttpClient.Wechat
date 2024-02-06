using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 用于构造 <see cref="WechatWorkClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatWorkClientBuilder : ICommonClientBuilder<WechatWorkClient>
    {
        private readonly WechatWorkClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatWorkClientBuilder(WechatWorkClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatWorkClient> ICommonClientBuilder<WechatWorkClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatWorkClient> ICommonClientBuilder<WechatWorkClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatWorkClient> ICommonClientBuilder<WechatWorkClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatWorkClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatWorkClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatWorkClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatWorkClient Build()
        {
            WechatWorkClient client = _disposeClient.HasValue
                ? new WechatWorkClient(_options, _httpClient, _disposeClient.Value)
                : new WechatWorkClient(_options, _httpClient);

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

    partial class WechatWorkClientBuilder
    {
        public static WechatWorkClientBuilder Create(WechatWorkClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatWorkClientBuilder(options);
        }
    }
}
