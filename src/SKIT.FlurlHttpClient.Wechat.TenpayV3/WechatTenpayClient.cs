using System;
using System.Net.Http;
using System.Reflection;
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
        public Settings.ICertificateManager PlatformCertificateManager { get; }

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
            : this(options, null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpClient"></param>
        /// <param name="disposeClient"></param>
        internal protected WechatTenpayClient(WechatTenpayClientOptions options, HttpClient? httpClient, bool disposeClient = true)
            : base(httpClient, disposeClient)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);
            PlatformCertificateManager = options.PlatformCertificateManager;
            AutoEncryptRequestSensitiveProperty = options.AutoEncryptRequestSensitiveProperty;
            AutoDecryptResponseSensitiveProperty = options.AutoDecryptResponseSensitiveProperty;

            FlurlClient.BaseUrl = options.Endpoint ?? WechatTenpayEndpoints.DEFAULT;
            FlurlClient.WithHeader(HttpHeaders.Accept, "application/json");
            FlurlClient.WithHeader(HttpHeaders.AcceptLanguage, options.AcceptLanguage);
            FlurlClient.WithHeader(HttpHeaders.UserAgent, $"OS/{Environment.OSVersion.Platform} SKIT.FlurlHttpClient.Wechat.Tenpay/{Assembly.GetAssembly(typeof(WechatTenpayClient))!.GetName().Version}");
            FlurlClient.WithTimeout(options.Timeout <= 0 ? Timeout.InfiniteTimeSpan : TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatTenpayRequestSigningInterceptor(
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
        /// <param name="httpMethod"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateFlurlRequest(WechatTenpayRequest request, HttpMethod httpMethod, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = base.CreateFlurlRequest(request, httpMethod, urlSegments);

            if (AutoEncryptRequestSensitiveProperty)
            {
                this.EncryptRequestSensitiveProperty(request);
            }

            if (request.WechatpayCertificateSerialNumber is not null)
            {
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
        public async Task<T> SendFlurlRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayResponse, new()
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
            where T : WechatTenpayResponse, new()
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

        private new async Task<TResponse> WrapFlurlResponseAsJsonAsync<TResponse>(IFlurlResponse flurlResponse, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayResponse, new()
        {
            TResponse result = await base.WrapFlurlResponseAsJsonAsync<TResponse>(flurlResponse, cancellationToken).ConfigureAwait(false);

            if (AutoDecryptResponseSensitiveProperty && result.IsSuccessful())
            {
                this.DecryptResponseSensitiveProperty(result);
            }

            return result;
        }
    }
}
