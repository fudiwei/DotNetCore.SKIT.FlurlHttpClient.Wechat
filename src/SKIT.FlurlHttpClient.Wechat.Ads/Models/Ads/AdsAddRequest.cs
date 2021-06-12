using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /ads/add 接口的请求。</para>
    /// </summary>
    public class AdsAddRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置广告组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adgroup_id")]
        [System.Text.Json.Serialization.JsonPropertyName("adgroup_id")]
        public long AdGroupId { get; set; }

        /// <summary>
        /// 获取或设置广告创意 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcreative_id")]
        [System.Text.Json.Serialization.JsonPropertyName("adcreative_id")]
        public long AdCreativeId { get; set; }

        /// <summary>
        /// 获取或设置广告名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_name")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_name")]
        public string AdName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("configured_status")]
        [System.Text.Json.Serialization.JsonPropertyName("configured_status")]
        public string? ConfiguredStatus { get; set; }
    }
}
