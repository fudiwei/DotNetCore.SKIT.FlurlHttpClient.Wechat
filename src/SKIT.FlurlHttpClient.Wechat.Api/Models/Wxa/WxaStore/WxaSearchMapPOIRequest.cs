using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/search_map_poi 接口的请求。</para>
    /// </summary>
    public class WxaSearchMapPOIRequest : WechatApiRequest, IMapResponse<WxaSearchMapPOIRequest, WxaSearchMapPOIResponse>
    {
        /// <summary>
        /// 获取或设置区域 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("districtid")]
        [System.Text.Json.Serialization.JsonPropertyName("districtid")]
        public int DistrictId { get; set; }

        /// <summary>
        /// 获取或设置搜索的关键字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string Keyword { get; set; } = string.Empty;
    }
}
