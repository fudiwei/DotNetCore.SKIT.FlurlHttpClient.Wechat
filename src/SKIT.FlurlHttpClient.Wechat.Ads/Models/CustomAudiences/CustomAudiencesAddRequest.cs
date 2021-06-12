using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /custom_audiences/add 接口的请求。</para>
    /// </summary>
    public class CustomAudiencesAddRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置自定义人群名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string CustomAudienceName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义人群类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string CustomAudienceType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义人群描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string CustomAudienceDescription { get; set; } = string.Empty;
    }
}
