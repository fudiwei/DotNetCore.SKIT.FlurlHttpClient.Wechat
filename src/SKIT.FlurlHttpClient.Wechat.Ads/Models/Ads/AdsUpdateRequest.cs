namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /ads/update 接口的请求。</para>
    /// </summary>
    public class AdsUpdateRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置广告 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
        public long AdId { get; set; }

        /// <summary>
        /// 获取或设置广告名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_name")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_name")]
        public string? AdName { get; set; }

        /// <summary>
        /// 获取或设置广告状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("configured_status")]
        [System.Text.Json.Serialization.JsonPropertyName("configured_status")]
        public string? ConfiguredStatus { get; set; }
    }
}
