using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/newguidetagoption 接口的请求。</para>
    /// </summary>
    public class CgibinGuideNewGuideTagOptionRequest : WechatApiRequest, IMapResponse<CgibinGuideNewGuideTagOptionRequest, CgibinGuideNewGuideTagOptionResponse>
    {
        /// <summary>
        /// 获取或设置标签类型名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_name")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        public string TagName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标签可选值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_values")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_values")]
        public IList<string> TagValues { get; set; } = new List<string>();
    }
}
