using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 一个微信支付 API HTTP 客户端。
    /// </summary>
    public partial class WechatTenpayClient : WechatClientBase
    {
        /// <summary>
        /// 获取当前客户端使用的微信商户号。
        /// </summary>
        public string WechatMerchantId { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户 API 证书序列号（用于请求签名）。
        /// </summary>
        internal string WechatMerchantCertSerialNumber { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户 API 证书私钥（用于请求签名、响应数据解密）。
        /// </summary>
        internal string WechatMerchantCertPrivateKey { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户 API v3 密钥（用于事件数据解密）。
        /// </summary>
        internal string WechatMerchantV3Secret { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户平台证书存储器。
        /// </summary>
        internal Settings.ICertificateStorer? WechatCertificateStorer { get; }

        /// <summary>
        /// 获取当前客户端使用的 JSON 序列化器。
        /// </summary>
        internal ISerializer FlurlJsonSerializer
        {
            get { return FlurlClient.Settings?.JsonSerializer ?? new FlurlNewtonsoftJsonSerializer(); }
        }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayClient(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            WechatMerchantId = options.MerchantId;
            WechatMerchantCertSerialNumber = options.MerchantCertSerialNumber;
            WechatMerchantCertPrivateKey = options.MerchantCertPrivateKey;
            WechatMerchantV3Secret = options.MerchantV3Secret;
            WechatCertificateStorer = options.CertificateStorer;

            FlurlClient.BaseUrl = options.Endpoints ?? WechatTenpayEndpoints.DEFAULT;
            FlurlClient.Headers.Remove("Accept");
            FlurlClient.Headers.Remove("Accept-Language");
            FlurlClient.Headers.Remove("User-Agent");
            FlurlClient.WithHeader("Accept", "application/json");
            FlurlClient.WithHeader("Accept-Language", options.AcceptLanguage);
            FlurlClient.WithHeader("User-Agent", options.UserAgent);
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatTenpaySignInterceptor(
                scheme: options.AuthScheme,
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

            if (request.Timeout.HasValue)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (!string.IsNullOrEmpty(request.WechatpayCertSerialNumber))
            {
                flurlRequest.Headers.Remove("Wechatpay-Serial");
                flurlRequest.WithHeader("Wechatpay-Serial", request.WechatpayCertSerialNumber);
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
            if (httpContent != null)
            {
                if (string.IsNullOrEmpty(httpContent.Headers.ContentType?.MediaType))
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
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
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatTenpayException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse flurlResponse)
            where T : WechatTenpayResponse, new()
        {
            string contentType = flurlResponse.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson =
                (flurlResponse.StatusCode == (int)HttpStatusCode.NoContent) ||
                (flurlResponse.StatusCode == (int)HttpStatusCode.OK && !contentType.StartsWith("application/json") && !contentType.StartsWith("text/json"));

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
            result.WechatpayRequestId = flurlResponse.Headers.GetAll("Request-ID").FirstOrDefault() ?? string.Empty;
            result.WechatpayNonce = flurlResponse.Headers.GetAll("Wechatpay-Nonce").FirstOrDefault() ?? string.Empty;
            result.WechatpayTimestamp = flurlResponse.Headers.GetAll("Wechatpay-Timestamp").FirstOrDefault() ?? string.Empty;
            result.WechatpaySignature = flurlResponse.Headers.GetAll("Wechatpay-Signature").FirstOrDefault() ?? string.Empty;
            result.WechatpayCertSerialNumber = flurlResponse.Headers.GetAll("Wechatpay-Serial").FirstOrDefault() ?? string.Empty;
            return result;
        }
    }
}
