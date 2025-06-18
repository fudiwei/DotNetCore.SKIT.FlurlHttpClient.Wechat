using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 用于构造 <see cref="WechatChatbotClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatChatbotClientBuilder : ICommonClientBuilder<WechatChatbotClient>
    {
        private readonly WechatChatbotClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatChatbotClientBuilder(WechatChatbotClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatChatbotClient> ICommonClientBuilder<WechatChatbotClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatChatbotClient> ICommonClientBuilder<WechatChatbotClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatChatbotClient> ICommonClientBuilder<WechatChatbotClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatChatbotClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatChatbotClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatChatbotClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatChatbotClient Build()
        {
            WechatChatbotClient client = _disposeClient.HasValue
                ? new WechatChatbotClient(_options, _httpClient, _disposeClient.Value)
                : new WechatChatbotClient(_options, _httpClient);

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

    partial class WechatChatbotClientBuilder
    {
        public static WechatChatbotClientBuilder Create(WechatChatbotClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatChatbotClientBuilder(options);
        }
    }
}
