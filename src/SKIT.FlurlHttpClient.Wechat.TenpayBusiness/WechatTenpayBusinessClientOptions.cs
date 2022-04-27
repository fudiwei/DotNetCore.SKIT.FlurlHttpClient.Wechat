namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatTenpayBusinessClient"/> 时使用的配置项。
    /// </summary>
    public class WechatTenpayBusinessClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置腾讯微企付 API 域名。
        /// <para>默认值：<see cref="WechatTenpayBusinessEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = WechatTenpayBusinessEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置腾讯微企付 API 签名认证方式。
        /// <para>默认值：<see cref="Constants.SignAlgorithms.SHA245_WITH_RSA"/></para>
        /// </summary>
        public string SignAlgorithm { get; set; } = Constants.SignAlgorithms.SHA245_WITH_RSA;

        /// <summary>
        /// 获取或设置腾讯微企付平台账号。
        /// </summary>
        public string PlatformId { get; set; } = default!;

        /// <summary>
        /// 获取或设置腾讯微企付平台 API 证书序列号。
        /// </summary>
        public string PlatformCertificateSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置腾讯微企付平台 API 证书私钥。
        /// </summary>
        public string PlatformCertificatePrivateKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置腾讯微企付证书序列号。
        /// </summary>
        public string TBEPCertificateSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置腾讯微企付证书公钥。
        /// </summary>
        public string TBEPCertificatePublicKey { get; set; } = default!;
    }
}
