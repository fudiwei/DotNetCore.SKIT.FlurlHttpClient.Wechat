namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// <para>微信 API 接口域名。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Interface_field_description.html ]]>
    /// </para>
    /// </summary>
    public static class WechatApiEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://api.weixin.qq.com";

        /// <summary>
        /// 容灾备用域名。
        /// </summary>
        public const string BACKUP = "https://api2.weixin.qq.com";

        /// <summary>
        /// 上海域名。
        /// </summary>
        public const string REGION_SHANGHAI = "https://sh.api.weixin.qq.com";

        /// <summary>
        /// 深圳域名。
        /// </summary>
        public const string REGION_SHENZHEN = "https://sz.api.weixin.qq.com";

        /// <summary>
        /// 香港域名。
        /// </summary>
        public const string REGION_HONGKONG = "https://hk.api.weixin.qq.com";
    }
}
