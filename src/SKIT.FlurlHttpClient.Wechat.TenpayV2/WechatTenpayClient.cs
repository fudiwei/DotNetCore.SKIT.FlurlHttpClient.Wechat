using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 一个微信支付 API HTTP 客户端。
    /// </summary>
    public partial class WechatTenpayClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信商户平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayClient(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoints ?? WechatTenpayEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
            FlurlClient.Configure((settings) =>
                settings.HttpClientFactory = new Settings.HttpClientFactory(
                    options.MerchantCertificateBytes,
                    options.MerchantCertificatePassword ?? options.MerchantId
                )
            );
        }

        /// <summary>
        /// 用指定的微信商户号和微信商户 API 密钥初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="merchantId">微信商户号。</param>
        /// <param name="merchantSecret">微信商户 API 密钥。</param>
        public WechatTenpayClient(string merchantId, string merchantSecret)
            : this(new WechatTenpayClientOptions() { MerchantId = merchantId, MerchantSecret = merchantSecret })
        {
            if (merchantId == null) throw new ArgumentNullException(nameof(merchantId));
            if (merchantSecret == null) throw new ArgumentNullException(nameof(merchantSecret));
        }

        /// <summary>
        /// 用指定的微信商户号、微信商户 API 密钥和微信商户证书内容初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="merchantId">微信商户号。</param>
        /// <param name="merchantSecret">微信商户 API 密钥。</param>
        /// <param name="merchantCertificateBytes">微信商户 API 证书内容字节数组。</param>
        /// <param name="merchantCertificatePassword">微信商户 API 证书导入密码。</param>
        public WechatTenpayClient(string merchantId, string merchantSecret, byte[] merchantCertificateBytes, string? merchantCertificatePassword = null)
            : this(new WechatTenpayClientOptions() { MerchantId = merchantId, MerchantSecret = merchantSecret, MerchantCertificateBytes = merchantCertificateBytes, MerchantCertificatePassword = merchantCertificatePassword })
        {
            if (merchantId == null) throw new ArgumentNullException(nameof(merchantId));
            if (merchantSecret == null) throw new ArgumentNullException(nameof(merchantSecret));
            if (merchantCertificateBytes == null) throw new ArgumentNullException(nameof(merchantCertificateBytes));
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(WechatTenpayRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.MerchantId == null)
            {
                request.MerchantId = Credentials.MerchantId;
            }

            if (request.AppId == null)
            {
                request.AppId = Credentials.AppId;
            }

            if (request is WechatTenpaySignableRequest signableRequest)
            {
                if (signableRequest.NonceString == null)
                {
                    signableRequest.NonceString = Guid.NewGuid().ToString("N");
                }

                if (signableRequest.Signature == null)
                {
                    try
                    {
                        signableRequest.Signature = Utilities.RequestSigner.SignFromJson(
                            json: JsonSerializer.Serialize(signableRequest),
                            secret: Credentials.MerchantSecret,
                            signType: signableRequest.SignType
                        );
                    }
                    catch (Exception ex)
                    {
                        throw new Exceptions.WechatTenpayRequestSignatureException("Generate signature of request failed. Please see the `InnerException` for more details.", ex);
                    }
                }
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
            where T : WechatTenpayResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatTenpayException(ex.Message, ex);
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
        public async Task<T> SendRequestWithXmlAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                bool isSimpleRequest = data == null ||
                    flurlRequest.Verb == HttpMethod.Get ||
                    flurlRequest.Verb == HttpMethod.Head ||
                    flurlRequest.Verb == HttpMethod.Options;
                if (isSimpleRequest)
                {
                    using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, null, cancellationToken);
                    return await WrapResponseWithXmlAsync<T>(flurlResponse, cancellationToken);
                }
                else
                {
                    string json = JsonSerializer.Serialize(data);
                    string xml = Utilities.XmlUtility.ConvertFromJson(json);

                    using HttpContent httpContent = new StringContent(xml, Encoding.UTF8, "text/xml");
                    using IFlurlResponse flurlResponse = await SendRequestAsync(flurlRequest, httpContent: httpContent, cancellationToken);
                    return await WrapResponseWithXmlAsync<T>(flurlResponse, cancellationToken);
                }
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatTenpayException(ex.Message, ex);
            }
        }

        private async Task<TResponse> WrapResponseWithXmlAsync<TResponse>(IFlurlResponse flurlResponse, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayResponse, new()
        {
            TResponse tmp = await WrapResponseAsync<TResponse>(flurlResponse, cancellationToken);
            byte tmpb1 = tmp.RawBytes.SkipWhile(b => b <= 32).FirstOrDefault(),
                 tmpb2 = tmp.RawBytes.Reverse().SkipWhile(b => b <= 32).FirstOrDefault();
            bool xmlable = tmp.RawStatus == 200 && (tmpb1 == 60 && tmpb2 == 62); // "<...>"

            TResponse result;
            if (xmlable)
            {
                string xml = Encoding.UTF8.GetString(tmp.RawBytes);
                string json = Utilities.XmlUtility.ConvertToJson(xml);

                result = JsonSerializer.Deserialize<TResponse>(json);
                result.RawStatus = tmp.RawStatus;
                result.RawHeaders = tmp.RawHeaders;
                result.RawBytes = tmp.RawBytes;
            }
            else
            {
                result = tmp;
            }

            return result;
        }
    }
}
