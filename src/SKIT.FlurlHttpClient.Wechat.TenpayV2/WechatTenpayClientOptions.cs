namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatTenpayClient"/> 时使用的配置项。
    /// </summary>
    public class WechatTenpayClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微信支付 API 域名。
        /// <para>默认值：<see cref="WechatTenpayEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = WechatTenpayEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信商户 API 密钥（注意与 API v3 密钥相区分）。
        /// </summary>
        public string MerchantSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信商户 API 证书内容字节数组。仅部分敏感接口需要传入此参数。
        /// </summary>
        public byte[]? MerchantCertificateBytes { get; set; }

        /// <summary>
        /// 获取或设置微信商户 API 证书导入密码。仅部分敏感接口需要传入此参数。
        /// <para>默认值：与 <see cref="MerchantId"/> 参数值相同。</para>
        /// </summary>
        public string? MerchantCertificatePassword { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。若一个商户号下关联多个 AppId 的，该参数可以置空，改为在请求时传入。
        /// </summary>
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置企业微信企业支付密钥。
        /// </summary>
        public string? WeWorkPaymentSecret { get; set; }
    }
}
