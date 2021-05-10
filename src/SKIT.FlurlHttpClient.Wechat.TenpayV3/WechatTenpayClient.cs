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
        public string MerchantId { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户 API 证书序列号（用于请求签名）。
        /// </summary>
        internal string MerchantCertSerialNumber { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户 API 证书私钥（用于请求签名、响应数据解密）。
        /// </summary>
        internal string MerchantCertPrivateKey { get; }

        /// <summary>
        /// 获取当前客户端使用的微信商户 API v3 密钥（用于事件数据解密）。
        /// </summary>
        internal string MerchantV3Secret { get; }

        /// <summary>
        /// 获取当前客户端使用的 JSON 序列化器。
        /// </summary>
        internal ISerializer JsonSerializer
        {
            get { return ProxyFlurlClient.Settings?.JsonSerializer ?? new FlurlNewtonsoftJsonSerializer(); }
        }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayClient(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            MerchantId = options.MerchantId;
            MerchantCertSerialNumber = options.MerchantCertSerialNumber;
            MerchantCertPrivateKey = options.MerchantCertPrivateKey;
            MerchantV3Secret = options.MerchantV3Secret;

            ProxyFlurlClient.BaseUrl = options.Endpoints ?? WechatTenpayEndpoints.DEFAULT;
            ProxyFlurlClient.Configure(settings =>
            {
                settings.Timeout = TimeSpan.FromMilliseconds(options.Timeout);
            });
            ProxyFlurlClient.Headers.Remove("Accept");
            ProxyFlurlClient.Headers.Remove("Accept-Language");
            ProxyFlurlClient.Headers.Remove("User-Agent");
            ProxyFlurlClient.WithHeader("Accept", "application/json");
            ProxyFlurlClient.WithHeader("Accept-Language", options.AcceptLanguage);
            ProxyFlurlClient.WithHeader("User-Agent", options.UserAgent);

            var interceptorAuthenticator = new Interceptors.WechatTenpayAuthenticator(
                scheme: options.AuthScheme,
                mchId: options.MerchantId,
                mchCertSn: options.MerchantCertSerialNumber,
                mchCertPk: options.MerchantCertPrivateKey
            );
            ProxyFlurlClient.BeforeCall((call) => interceptorAuthenticator.Authenticate(call));
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(IFlurlRequest request, HttpContent? content = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayResponse, new()
        {
            if (content != null)
            {
                if (string.IsNullOrEmpty(content.Headers.ContentType?.MediaType))
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            try
            {
                using IFlurlResponse response = await base.SendRequestAsync(request, content, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
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
        /// <param name="request"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest request, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayResponse, new()
        {
            try
            {
                using IFlurlResponse response = await base.SendRequestWithJsonAsync(request, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatTenpayException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse response)
            where T : WechatTenpayResponse, new()
        {
            string contentType = response.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson =
                (response.StatusCode == (int)HttpStatusCode.NoContent) ||
                (response.StatusCode == (int)HttpStatusCode.OK && !contentType.StartsWith("application/json") && !contentType.StartsWith("text/json"));

            T result = contentTypeIsNotJson ? new T() : await response.GetJsonAsync<T>().ConfigureAwait(false);
            result.RawStatus = response.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                response.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = await response.ResponseMessage.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            result.WechatpayRequestId = response.Headers.GetAll("Request-ID").FirstOrDefault() ?? string.Empty;
            result.WechatpayNonce = response.Headers.GetAll("Wechatpay-Nonce").FirstOrDefault() ?? string.Empty;
            result.WechatpayTimestamp = response.Headers.GetAll("Wechatpay-Timestamp").FirstOrDefault() ?? string.Empty;
            result.WechatpaySignature = response.Headers.GetAll("Wechatpay-Signature").FirstOrDefault() ?? string.Empty;
            result.WechatpayCertSerialNumber = response.Headers.GetAll("Wechatpay-Serial").FirstOrDefault() ?? string.Empty;
            return result;
        }
    }
}
