using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Settings
{
    public sealed class Credentials
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
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.EnterpriseId"/> 的副本。
        /// </summary>
        public string? EnterpriseId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.EnterpriseCertificateSerialNumber"/> 的副本。
        /// </summary>
        public string? EnterpriseCertificateSerialNumber { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.EnterpriseCertificatePrivateKey"/> 的副本。
        /// </summary>
        public string? EnterpriseCertificatePrivateKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.TBEPCertificateSerialNumber"/> 的副本。
        /// </summary>
        public string TBEPCertificateSerialNumber { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.TBEPCertificatePublicKey"/> 的副本。
        /// </summary>
        public string TBEPCertificatePublicKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.SensitivePropertyEncryptionAlgorithm"/> 的副本。
        /// </summary>
        public string SensitivePropertyEncryptionAlgorithm { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.SensitivePropertyEncryptionSM4Key"/> 的副本。
        /// </summary>
        public string? SensitivePropertyEncryptionSM4Key { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayBusinessClientOptions.SensitivePropertyEncryptionSM4IV"/> 的副本。
        /// </summary>
        public string? SensitivePropertyEncryptionSM4IV { get; set; }

        internal Credentials(WechatTenpayBusinessClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            PlatformId = options.PlatformId;
            PlatformCertificateSerialNumber = options.PlatformCertificateSerialNumber;
            PlatformCertificatePrivateKey = options.PlatformCertificatePrivateKey;
            EnterpriseId = options.EnterpriseId;
            EnterpriseCertificateSerialNumber = options.EnterpriseCertificateSerialNumber;
            EnterpriseCertificatePrivateKey = options.EnterpriseCertificatePrivateKey;
            TBEPCertificateSerialNumber = options.TBEPCertificateSerialNumber;
            TBEPCertificatePublicKey = options.TBEPCertificatePublicKey;
            SensitivePropertyEncryptionAlgorithm = options.SensitivePropertyEncryptionAlgorithm;
            SensitivePropertyEncryptionSM4Key = options.SensitivePropertyEncryptionSM4Key;
            SensitivePropertyEncryptionSM4IV = options.SensitivePropertyEncryptionSM4IV;
        }
    }
}
