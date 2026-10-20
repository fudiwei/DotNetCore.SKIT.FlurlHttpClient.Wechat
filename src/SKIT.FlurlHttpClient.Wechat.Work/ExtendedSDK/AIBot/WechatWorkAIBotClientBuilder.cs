namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    /// <summary>
    /// 用于构造 <see cref="WechatWorkAIBotClient"/> 实例的构造器。
    /// </summary>
    public partial class WechatWorkAIBotClientBuilder : ICommonClientBuilder<WechatWorkAIBotClient>
    {
        private readonly WechatWorkAIBotClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private WechatWorkAIBotClientBuilder(WechatWorkAIBotClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<WechatWorkAIBotClient> ICommonClientBuilder<WechatWorkAIBotClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<WechatWorkAIBotClient> ICommonClientBuilder<WechatWorkAIBotClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<WechatWorkAIBotClient> ICommonClientBuilder<WechatWorkAIBotClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public WechatWorkAIBotClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public WechatWorkAIBotClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public WechatWorkAIBotClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public WechatWorkAIBotClient Build()
        {
            WechatWorkAIBotClient client = _disposeClient.HasValue
                ? new WechatWorkAIBotClient(_options, _httpClient, _disposeClient.Value)
                : new WechatWorkAIBotClient(_options, _httpClient);

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

    partial class WechatWorkAIBotClientBuilder
    {
        public static WechatWorkAIBotClientBuilder Create(WechatWorkAIBotClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new WechatWorkAIBotClientBuilder(options);
        }
    }
}
