using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /custom_audiences/update 接口的请求。</para>
    /// </summary>
    public class CustomAudiencesUpdateRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置自定义人群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audience_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audience_id")]
        public int CustomAudienceId { get; set; }

        /// <summary>
        /// 获取或设置自定义人群名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? CustomAudienceName { get; set; }

        /// <summary>
        /// 获取或设置自定义人群描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? CustomAudienceDescription { get; set; }
    }
}
