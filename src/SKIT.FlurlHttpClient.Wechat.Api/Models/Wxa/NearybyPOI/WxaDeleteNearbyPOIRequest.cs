using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/delnearbypoi 接口的请求。</para>
    /// </summary>
    public class WxaDeleteNearbyPOIRequest : WechatApiRequest, IMapResponse<WxaDeleteNearbyPOIRequest, WxaDeleteNearbyPOIResponse>
    {
        /// <summary>
        /// 获取或设置附近地点 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;
    }
}
