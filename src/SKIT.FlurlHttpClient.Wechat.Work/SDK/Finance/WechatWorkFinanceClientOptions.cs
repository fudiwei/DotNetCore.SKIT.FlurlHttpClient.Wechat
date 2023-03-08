namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatWorkFinanceClient"/> 时使用的配置项。
    /// </summary>
    public class WechatWorkFinanceClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒），建议设置为 1000 的整数倍。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置代理地址。
        /// </summary>
        public string? ProxyAddress { get; set; }

        /// <summary>
        /// 获取或设置代理认证信息（如账号、密码）。
        /// </summary>
        public string? ProxyAuthentication { get; set; }

        /// <summary>
        /// 获取或设置企业微信 CorpId。
        /// </summary>
        public string CorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业微信会话内容存档 SecretKey。
        /// </summary>
        public string SecretKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业微信会话内容存档消息加解密 RSA 私钥。
        /// </summary>
        public string RsaPrivateKey { get; set; } = default!;
    }
}
