using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/poi/getpoi 接口的请求。</para>
    /// </summary>
    public class CgibinPOIGetPOIRequest : WechatApiRequest, IMapResponse<CgibinPOIGetPOIRequest, CgibinPOIGetPOIResponse>
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;
    }
}
