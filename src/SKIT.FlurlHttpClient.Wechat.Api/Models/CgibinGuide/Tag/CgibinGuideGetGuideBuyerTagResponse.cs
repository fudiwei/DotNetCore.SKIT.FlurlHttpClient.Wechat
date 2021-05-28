using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidebuyertag 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideBuyerTagResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置标签可选值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_values")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_values")]
        public string[] TagValues { get; set; } = default!;
    }
}
