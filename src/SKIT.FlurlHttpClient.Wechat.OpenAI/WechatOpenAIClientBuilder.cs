using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 用于构造 <see cref="WechatOpenAIClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatOpenAIClientBuilder : ICommonClientBuilder<WechatOpenAIClient>
    {
        private readonly WechatOpenAIClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatOpenAIClientBuilder(WechatOpenAIClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatOpenAIClient> ICommonClientBuilder<WechatOpenAIClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatOpenAIClient> ICommonClientBuilder<WechatOpenAIClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatOpenAIClient> ICommonClientBuilder<WechatOpenAIClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatOpenAIClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatOpenAIClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatOpenAIClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatOpenAIClient Build()
        {
            WechatOpenAIClient client = _disposeClient.HasValue
                ? new WechatOpenAIClient(_options, _httpClient, _disposeClient.Value)
                : new WechatOpenAIClient(_options, _httpClient);

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

    partial class WechatOpenAIClientBuilder
    {
        public static WechatOpenAIClientBuilder Create(WechatOpenAIClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatOpenAIClientBuilder(options);
        }
    }
}
