using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 一个微信智能对话 API HTTP 客户端。
    /// </summary>
    public class WechatOpenAIClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信智能对话平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatOpenAIClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatOpenAIClient(WechatOpenAIClientOptions options)
            : this(options, null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpClient"></param>
        /// <param name="disposeClient"></param>
        internal protected WechatOpenAIClient(WechatOpenAIClientOptions options, HttpClient? httpClient, bool disposeClient = true)
            : base(httpClient, disposeClient)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? WechatOpenAIEndpoints.DEFAULT;
            FlurlClient.WithTimeout(options.Timeout <= 0 ? Timeout.InfiniteTimeSpan : TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatOpenAIRequestEncryptionInterceptor(
                baseUrl: FlurlClient.BaseUrl,
                encodingAESKey: Credentials.EncodingAESKey,
                customEncryptedRequestPathMatcher: options.CustomEncryptedRequestPathMatcher
            ));
            Interceptors.Add(new Interceptors.WechatOpenAIRequestSigningInterceptor(
                token: Credentials.Token
            ));
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="httpMethod"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateFlurlRequest(WechatOpenAIRequest request, HttpMethod httpMethod, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = base.CreateFlurlRequest(request, httpMethod, urlSegments);

            if (request.RequestId is null)
            {
                request.RequestId = Guid.NewGuid().ToString("N");
            }

            return flurlRequest
                .WithHeader("X-APPID", Credentials.AppId)
                .WithHeader("X-OPENAI-TOKEN", request.AccessToken)
                .WithHeader("request_id", request.RequestId);
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendFlurlRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : WechatOpenAIResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            using IFlurlResponse flurlResponse = await base.SendFlurlRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendFlurlRequestAsJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatOpenAIResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            bool isSimpleRequest = data is null ||
                flurlRequest.Verb == HttpMethod.Get ||
                flurlRequest.Verb == HttpMethod.Head ||
                flurlRequest.Verb == HttpMethod.Options;
            using IFlurlResponse flurlResponse = isSimpleRequest ?
                await base.SendFlurlRequestAsync(flurlRequest, null, cancellationToken).ConfigureAwait(false) :
                await base.SendFlurlRequestAsJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
        }
    }
}
