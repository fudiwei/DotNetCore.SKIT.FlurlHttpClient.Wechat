using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Settings
{
    public sealed class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantId"/> 的副本。
        /// </summary>
        public string MerchantId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantSecret"/> 的副本。
        /// </summary>
        public string MerchantSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantCertificateBytes"/> 的副本。
        /// </summary>
        public byte[]? MerchantCertificateBytes { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantCertificatePassword"/> 的副本。
        /// </summary>
        public string? MerchantCertificatePassword { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.AppId"/> 的副本。
        /// </summary>
        public string? AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.WeWorkPaymentSecret"/> 的副本。
        /// </summary>
        public string? WeWorkPaymentSecret { get; }

        internal Credentials(WechatTenpayClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            MerchantId = options.MerchantId;
            MerchantSecret = options.MerchantSecret;
            MerchantCertificateBytes = options.MerchantCertificateBytes;
            MerchantCertificatePassword = options.MerchantCertificatePassword;
            AppId = options.AppId;
            WeWorkPaymentSecret = options.WeWorkPaymentSecret;
        }
    }
}
