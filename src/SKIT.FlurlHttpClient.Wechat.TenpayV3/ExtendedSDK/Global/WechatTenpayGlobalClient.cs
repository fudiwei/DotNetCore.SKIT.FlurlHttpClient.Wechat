using System;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    /// <summary>
    /// 一个微信支付 Global API HTTP 客户端。
    /// </summary>
    public class WechatTenpayGlobalClient : WechatTenpayClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信支付商户凭证。
        /// </summary>
        public new Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayGlobalClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayGlobalClient(WechatTenpayGlobalClientOptions options)
            : this(options, null)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpClient"></param>
        /// <param name="disposeClient"></param>
        internal protected WechatTenpayGlobalClient(WechatTenpayGlobalClientOptions options, HttpClient? httpClient, bool disposeClient = true)
            : base(
                new WechatTenpayClientOptions()
                {
                    Timeout = options.Timeout,
                    Endpoint = options.Endpoint,
                    AcceptLanguage = options.AcceptLanguage,
                    SignScheme = options.SignScheme,
                    MerchantId = options.MerchantId,
                    MerchantV3Secret = options.MerchantV3Secret,
                    MerchantCertificateSerialNumber = options.MerchantCertificateSerialNumber,
                    MerchantCertificatePrivateKey = options.MerchantCertificatePrivateKey,
                    AutoEncryptRequestSensitiveProperty = options.AutoEncryptRequestSensitiveProperty,
                    AutoDecryptResponseSensitiveProperty = options.AutoDecryptResponseSensitiveProperty,
                    PlatformCertificateManager = options.PlatformCertificateManager
                },
                httpClient,
                disposeClient
            )
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? WechatTenpayGlobalEndpoints.DEFAULT;
        }
    }
}
