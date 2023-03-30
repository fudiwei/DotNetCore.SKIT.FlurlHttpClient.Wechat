using System;
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
        /// 获取当前客户端使用的微信支付商户凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 获取当前客户端使用的微信支付平台证书管理器。
        /// </summary>
        public Settings.CertificateManager PlatformCertificateManager { get; }

        /// <summary>
        /// 获取是否自动加密请求中的敏感信息字段。
        /// </summary>
        protected internal bool AutoEncryptRequestSensitiveProperty { get; }

        /// <summary>
        /// 获取是否自动解密请求中的敏感信息字段。
        /// </summary>
        protected internal bool AutoDecryptResponseSensitiveProperty { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayClient(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);
            PlatformCertificateManager = options.PlatformCertificateManager;
            AutoEncryptRequestSensitiveProperty = options.AutoEncryptRequestSensitiveProperty;
            AutoDecryptResponseSensitiveProperty = options.AutoDecryptResponseSensitiveProperty;

            FlurlClient.BaseUrl = options.Endpoint ?? WechatTenpayEndpoints.DEFAULT;
            FlurlClient.Headers.Remove(FlurlHttpClient.Constants.HttpHeaders.Accept);
            FlurlClient.Headers.Remove(FlurlHttpClient.Constants.HttpHeaders.AcceptLanguage);
            FlurlClient.Headers.Remove(FlurlHttpClient.Constants.HttpHeaders.UserAgent);
            FlurlClient.WithHeader(FlurlHttpClient.Constants.HttpHeaders.Accept, "application/json");
            FlurlClient.WithHeader(FlurlHttpClient.Constants.HttpHeaders.AcceptLanguage, options.AcceptLanguage);
            FlurlClient.WithHeader(FlurlHttpClient.Constants.HttpHeaders.UserAgent, options.UserAgent);
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatTenpayRequestSignatureInterceptor(
                scheme: options.SignScheme,
                mchId: options.MerchantId,
                mchCertSn: options.MerchantCertificateSerialNumber,
                mchCertPk: options.MerchantCertificatePrivateKey
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

            if (AutoEncryptRequestSensitiveProperty)
            {
                this.EncryptRequestSensitiveProperty(request);
            }

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.WechatpayCertificateSerialNumber != null)
            {
                flurlRequest.Headers.Remove("Wechatpay-Serial");
                flurlRequest.WithHeader("Wechatpay-Serial", request.WechatpayCertificateSerialNumber);
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
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.WechatTenpayRequestTimeoutException(ex.Message, ex);
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
                    await base.SendRequestAsync(flurlRequest, null, cancellationToken) :
                    await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.WechatTenpayRequestTimeoutException(ex.Message, ex);
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
            result.WechatpayRequestId = flurlResponse.Headers.FirstOrDefault("Request-ID") ?? string.Empty;
            result.WechatpayNonce = flurlResponse.Headers.FirstOrDefault("Wechatpay-Nonce") ?? string.Empty;
            result.WechatpayTimestamp = flurlResponse.Headers.FirstOrDefault("Wechatpay-Timestamp") ?? string.Empty;
            result.WechatpaySignatureType = flurlResponse.Headers.FirstOrDefault("Wechatpay-Signature-Type") ?? string.Empty;
            result.WechatpaySignature = flurlResponse.Headers.FirstOrDefault("Wechatpay-Signature") ?? string.Empty;
            result.WechatpayCertificateSerialNumber = flurlResponse.Headers.FirstOrDefault("Wechatpay-Serial") ?? string.Empty;

            if (AutoDecryptResponseSensitiveProperty && result.IsSuccessful())
            {
                this.DecryptResponseSensitiveProperty(result);
            }

            return result;
        }
    }
}
