using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Settings
{
    public sealed class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayGlobalClientOptions.MerchantId"/> 的副本。
        /// </summary>
        public string MerchantId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayGlobalClientOptions.MerchantV3Secret"/> 的副本。
        /// </summary>
        public string MerchantV3Secret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayGlobalClientOptions.MerchantCertificateSerialNumber"/> 的副本。
        /// </summary>
        public string MerchantCertificateSerialNumber { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayGlobalClientOptions.MerchantCertificatePrivateKey"/> 的副本。
        /// </summary>
        public string MerchantCertificatePrivateKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayGlobalClientOptions.SignScheme"/> 的副本。
        /// </summary>
        internal string SignScheme { get; }

        internal Credentials(WechatTenpayGlobalClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            MerchantId = options.MerchantId;
            MerchantV3Secret = options.MerchantV3Secret;
            MerchantCertificateSerialNumber = options.MerchantCertificateSerialNumber;
            MerchantCertificatePrivateKey = options.MerchantCertificatePrivateKey;
            SignScheme = options.SignScheme;
        }
    }
}
