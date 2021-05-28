using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setnearbypoishowstatus 接口的请求。</para>
    /// </summary>
    public class WxaSetNearbyPOIShowStatusRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置附近地点 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否展示。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
        public bool IsShow { get; set; }
    }
}
