using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 一个微信智能对话第三方接入 API HTTP 客户端。
    /// </summary>
    public class WechatOpenAIThirdPartyClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信智能对话平台凭证。
        /// </summary>
        public Settings.ThirdPartyCredentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatOpenAIThirdPartyClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatOpenAIThirdPartyClient(WechatOpenAIThirdPartyClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.ThirdPartyCredentials(options);

            FlurlClient.BaseUrl = options.Endpoints ?? WechatOpenAIThirdPartyEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 用指定的微信智能对话 ClientId、ClientKey 初始化 <see cref="WechatOpenAIPlatformClient"/> 类的新实例。
        /// </summary>
        /// <param name="clientId">微信智能对话 ClientId。</param>
        /// <param name="clientKey">微信智能对话 ClientKey。</param>
        public WechatOpenAIThirdPartyClient(string clientId, string clientKey)
            : this(new WechatOpenAIThirdPartyClientOptions() { ClientId = clientId, ClientKey = clientKey })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(WechatOpenAIThirdPartyRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.RequestId == null)
            {
                request.RequestId = Guid.NewGuid().ToString("N");
            }

            flurlRequest.WithHeader("request_id", request.RequestId);

            if (request.BotId != null)
            {
                flurlRequest.WithHeader("wxbot_bid", request.BotId);
            }

            if (request.AccessToken != null)
            {
                flurlRequest.WithHeader("X-OPENAI-TOKEN", request.AccessToken);
            }

            return flurlRequest;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : WechatOpenAIThirdPartyResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatOpenAIException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatOpenAIThirdPartyResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatOpenAIException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse flurlResponse)
            where T : WechatOpenAIThirdPartyResponse, new()
        {
            byte[] bytes = await flurlResponse.GetBytesAsync().ConfigureAwait(false);
            bool jsonable =
                (bytes.Length > 1 && bytes[0] == 91 && bytes[bytes.Length - 1] == 93) || // "[...]"
                (bytes.Length > 1 && bytes[0] == 123 && bytes[bytes.Length - 1] == 125); // "{...}"

            T result = jsonable ? JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(bytes)) : new T();

            result.RawStatus = flurlResponse.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                flurlResponse.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = bytes;

            return result;
        }
    }
}
