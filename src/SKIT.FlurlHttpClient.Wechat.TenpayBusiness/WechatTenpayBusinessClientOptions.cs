namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatTenpayBusinessClient"/> 时使用的配置项。
    /// </summary>
    public class WechatTenpayBusinessClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>
        /// 默认值：30000
        /// </para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微企付 API 入口点。
        /// <para>
        /// 默认值：<see cref="WechatTenpayBusinessEndpoints.DEFAULT"/>
        /// </para>
        /// </summary>
        public string Endpoint { get; set; } = WechatTenpayBusinessEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微企付 API 签名认证方式。
        /// <para>
        /// 默认值：<see cref="Constants.SignAlgorithms.SHA256_WITH_RSA"/>
        /// </para>
        /// </summary>
        public string SignAlgorithm { get; set; } = Constants.SignAlgorithms.SHA256_WITH_RSA;

        /// <summary>
        /// 获取或设置微企付平台账号。
        /// </summary>
        public string PlatformId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付平台 API 证书序列号。
        /// </summary>
        public string PlatformCertificateSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付平台 API 证书私钥。
        /// </summary>
        public string PlatformCertificatePrivateKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付企业商户 ID。
        /// </summary>
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 获取或设置微企付企业商户 API 证书序列号。
        /// </summary>
        public string? EnterpriseCertificateSerialNumber { get; set; }

        /// <summary>
        /// 获取或设置微企付企业商户 API 证书私钥。
        /// </summary>
        public string? EnterpriseCertificatePrivateKey { get; set; }

        /// <summary>
        /// 获取或设置微企付 TBEP 证书序列号。
        /// </summary>
        public string TBEPCertificateSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付 TBEP 证书公钥。
        /// </summary>
        public string TBEPCertificatePublicKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置自动加密请求重敏感字段数据时使用的算法。
        /// <para>
        /// 默认值：<see cref="Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC"/>
        /// </para>
        /// </summary>
        public string SensitivePropertyEncryptionAlgorithm { get; set; } = Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC;

        /// <summary>
        /// 获取或设置自动加密请求中的敏感字段数据时 SM4 算法所需密钥。
        /// </summary>
        public string? SensitivePropertyEncryptionSM4Key { get; set; }

        /// <summary>
        /// 获取或设置自动加密请求中的敏感字段数据时 SM4 算法所需偏移量。
        /// </summary>
        public string? SensitivePropertyEncryptionSM4IV { get; set; }

        /// <summary>
        /// 获取或设置是否自动加密请求中的敏感字段数据。
        /// <para>
        /// 注意：启用该功能需配合 <see cref="SensitivePropertyEncryptionSM4Key"/> 和 <see cref="SensitivePropertyEncryptionSM4IV"/> 使用。
        /// </para>
        /// </summary>
        public bool AutoEncryptRequestSensitiveProperty { get; set; }

        /// <summary>
        /// 获取或设置是否自动解密响应中的敏感字段数据。
        /// </summary>
        public bool AutoDecryptResponseSensitiveProperty { get; set; }
    }
}
