namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatAdsClient"/> 时使用的配置项。
    /// </summary>
    public class WechatAdsClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微信广告平台 API 域名。
        /// <para>默认值：<see cref="WechatAdsEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = WechatAdsEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微信广告平台服务商 ID。
        /// </summary>
        public string AgencyId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信广告平台服务商 AppId。
        /// </summary>
        public string AgencyAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信广告平台服务商 ApiKey。
        /// </summary>
        public string AgencyApiKey { get; set; } = default!;
    }
}
