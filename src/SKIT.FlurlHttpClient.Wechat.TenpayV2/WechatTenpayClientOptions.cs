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
        /// 获取或设置微信支付 API 签名方式。
        /// <para>默认值：<see cref="Constants.SignTypes.MD5"/></para>
        /// </summary>
        public string SignType { get; set; } = Constants.SignTypes.MD5;

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信商户 API 密钥（注意与 API v3 密钥相区分）。
        /// </summary>
        public string MerchantSecret { get; set; } = default!;
    }
}
