using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.PlatformId"/> 的副本。
        /// </summary>
        public string PlatformId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.PlatformCertificateSerialNumber"/> 的副本。
        /// </summary>
        public string PlatformCertificateSerialNumber { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.PlatformCertificatePrivateKey"/> 的副本。
        /// </summary>
        public string PlatformCertificatePrivateKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.TBEPCertificateSerialNumber"/> 的副本。
        /// </summary>
        public string TBEPCertificateSerialNumber { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.TBEPCertificatePublicKey"/> 的副本。
        /// </summary>
        public string TBEPCertificatePublicKey { get; }

        internal Credentials(WechatTenpayBusinessClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            PlatformId = options.PlatformId;
            PlatformCertificateSerialNumber = options.PlatformCertificateSerialNumber;
            PlatformCertificatePrivateKey = options.PlatformCertificatePrivateKey;
            TBEPCertificateSerialNumber = options.TBEPCertificateSerialNumber;
            TBEPCertificatePublicKey = options.TBEPCertificatePublicKey;
        }
    }
}
