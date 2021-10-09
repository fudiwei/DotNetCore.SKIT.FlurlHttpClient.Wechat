using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 一个微信智能对话 API HTTP 客户端。
    /// </summary>
    public class WechatOpenAIClient : CommonClientBase, IWechatClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信公众平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatOpenAIClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatOpenAIClient(WechatOpenAIClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoints ?? WechatOpenAIEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 用指定的微信智能对话 ClientId 和微信智能对话 ClientKey 初始化 <see cref="WechatOpenAIClient"/> 类的新实例。
        /// </summary>
        /// <param name="clientId">微信智能对话 ClientId。</param>
        /// <param name="clientKey">微信智能对话 ClientKey。</param>
        public WechatOpenAIClient(string clientId, string clientKey)
            : this(new WechatOpenAIClientOptions() { ClientId = clientId, ClientKey = clientKey })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(WechatOpenAIRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout.HasValue)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.RequestId == null)
                request.RequestId = Guid.NewGuid().ToString("N");
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
            where T : WechatOpenAIResponse, new()
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
            where T : WechatOpenAIResponse, new()
        {
            try
            {
                if (data is WechatOpenAIRequestEncryptedXmlable xmlData)
                {
                    if (xmlData.AppId == null)
                        xmlData.AppId = Credentials.AppId;

                    string xml = Utilities.XmlUtility.Serialize(xmlData);
                    data = new { encrypt = Utilities.WxBizMsgCryptor.AESEncrypt(plainText: xml, encodingAESKey: Credentials.PushEncodingAESKey!, appId: xmlData.AppId!)  };
                }

                using IFlurlResponse flurlResponse = await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatOpenAIException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse flurlResponse)
            where T : WechatOpenAIResponse, new()
        {
            string contentType = flurlResponse.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson =
                (flurlResponse.StatusCode != (int)HttpStatusCode.OK) ||
                (!contentType.StartsWith("application/json") && !contentType.StartsWith("text/json"));

            T result = contentTypeIsNotJson ? new T() : await flurlResponse.GetJsonAsync<T>().ConfigureAwait(false);
            result.RawStatus = flurlResponse.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                flurlResponse.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = await flurlResponse.ResponseMessage.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            return result;
        }
    }
}
