namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    /// <summary>
    /// 微信广告平台 API 请求的基类。
    /// </summary>
    public abstract class WechatAdsRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置微信广告平台的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置微信广告平台的版本号。
        /// <para>
        /// 默认值："v1.0"
        /// </para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string Version { get; set; } = "v1.0";
    }
}
