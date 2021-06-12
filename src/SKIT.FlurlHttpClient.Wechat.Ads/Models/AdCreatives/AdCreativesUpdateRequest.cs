using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /adcreatives/update 接口的请求。</para>
    /// </summary>
    public class AdCreativesUpdateRequest : WechatAdsRequest
    {
        public static class Types
        {
            public class Element : AdCreativesAddRequest.Types.Element
            {
            }
        }

        /// <summary>
        /// 获取或设置广告创意 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcreative_id")]
        [System.Text.Json.Serialization.JsonPropertyName("adcreative_id")]
        public long AdCreativeId { get; set; }

        /// <summary>
        /// 获取或设置广告创意名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcreative_name")]
        [System.Text.Json.Serialization.JsonPropertyName("adcreative_name")]
        public string? AdCreativeName { get; set; }

        /// <summary>
        /// 获取或设置广告创意元素信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcreative_elements")]
        [System.Text.Json.Serialization.JsonPropertyName("adcreative_elements")]
        public Types.Element? AdCreativeElement { get; set; }

        /// <summary>
        /// 获取或设置目标 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destination_url")]
        [System.Text.Json.Serialization.JsonPropertyName("destination_url")]
        public string? DestinationUrl { get; set; }
    }
}
