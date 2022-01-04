using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 一个微信支付 API HTTP 客户端。
    /// </summary>
    public class WechatTenpayClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信商户平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户平台证书管理器。
        /// </summary>
        public Settings.CertificateManager CertificateManager { get; }

        /// <summary>
        /// 获取是否自动加密请求中的敏感信息字段。
        /// </summary>
        protected bool AutoEncryptRequestSensitiveProperty { get; }

        /// <summary>
        /// 获取是否自动解密请求中的敏感信息字段。
        /// </summary>
        protected bool AutoDecryptResponseSensitiveProperty { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayClient(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);
            CertificateManager = options.CertificateManager;
            AutoEncryptRequestSensitiveProperty = options.AutoEncryptRequestSensitiveProperty;
            AutoDecryptResponseSensitiveProperty = options.AutoDecryptResponseSensitiveProperty;

            FlurlClient.BaseUrl = options.Endpoints ?? WechatTenpayEndpoints.DEFAULT;
            FlurlClient.Headers.Remove(Contants.HttpHeaders.Accept);
            FlurlClient.Headers.Remove(Contants.HttpHeaders.AcceptLanguage);
            FlurlClient.Headers.Remove(Contants.HttpHeaders.UserAgent);
            FlurlClient.WithHeader(Contants.HttpHeaders.Accept, "application/json");
            FlurlClient.WithHeader(Contants.HttpHeaders.AcceptLanguage, options.AcceptLanguage);
            FlurlClient.WithHeader(Contants.HttpHeaders.UserAgent, options.UserAgent);
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatTenpaySignInterceptor(
                scheme: options.SignAlgorithm,
                mchId: options.MerchantId,
                mchCertSn: options.MerchantCertSerialNumber,
                mchCertPk: options.MerchantCertPrivateKey
            ));
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

            if (request.WechatpayCertSerialNumber != null)
            {
                flurlRequest.Headers.Remove("Wechatpay-Serial");
                flurlRequest.WithHeader("Wechatpay-Serial", request.WechatpayCertSerialNumber);
            }

            if (AutoEncryptRequestSensitiveProperty)
            {
                this.EncryptRequestSensitiveProperty(request);
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

            if (httpContent != null)
            {
                if (string.IsNullOrEmpty(httpContent.Headers.ContentType?.MediaType))
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
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
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                bool isSimpleRequest = data == null ||
                    flurlRequest.Verb == HttpMethod.Get ||
                    flurlRequest.Verb == HttpMethod.Head ||
                    flurlRequest.Verb == HttpMethod.Options;
                using IFlurlResponse flurlResponse = isSimpleRequest ?
                    await base.SendRequestAsync(flurlRequest, null, cancellationToken).ConfigureAwait(false) :
                    await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatTenpayException(ex.Message, ex);
            }
        }

        private new async Task<TResponse> WrapResponseWithJsonAsync<TResponse>(IFlurlResponse flurlResponse, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayResponse, new()
        {
            TResponse result = await base.WrapResponseWithJsonAsync<TResponse>(flurlResponse, cancellationToken);
            result.WechatpayRequestId = flurlResponse.Headers.GetAll("Request-ID").FirstOrDefault() ?? string.Empty;
            result.WechatpayNonce = flurlResponse.Headers.GetAll("Wechatpay-Nonce").FirstOrDefault() ?? string.Empty;
            result.WechatpayTimestamp = flurlResponse.Headers.GetAll("Wechatpay-Timestamp").FirstOrDefault() ?? string.Empty;
            result.WechatpaySignature = flurlResponse.Headers.GetAll("Wechatpay-Signature").FirstOrDefault() ?? string.Empty;
            result.WechatpayCertSerialNumber = flurlResponse.Headers.GetAll("Wechatpay-Serial").FirstOrDefault() ?? string.Empty;

            if (AutoDecryptResponseSensitiveProperty && result.IsSuccessful())
            {
                this.DecryptResponseSensitiveProperty(result);
            }

            return result;
        }
    }
}
