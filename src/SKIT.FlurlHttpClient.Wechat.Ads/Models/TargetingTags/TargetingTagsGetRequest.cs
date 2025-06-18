namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /targeting_tags/get 接口的请求。</para>
    /// </summary>
    public class TargetingTagsGetRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置标签类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TagType { get; set; } = string.Empty;
    }
}
