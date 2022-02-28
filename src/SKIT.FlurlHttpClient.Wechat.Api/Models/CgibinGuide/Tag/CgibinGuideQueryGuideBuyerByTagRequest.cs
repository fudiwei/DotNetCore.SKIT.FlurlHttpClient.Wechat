using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/queryguidebuyerbytag 接口的请求。</para>
    /// </summary>
    public class CgibinGuideQueryGuideBuyerByTagRequest : WechatApiRequest, IInferable<CgibinGuideQueryGuideBuyerByTagRequest, CgibinGuideQueryGuideBuyerByTagResponse>
    {
        /// <summary>
        /// 获取或设置顾问微信号。与字段 <see cref="GuideOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
        public string? GuideAccount { get; set; }

        /// <summary>
        /// 获取或设置顾问 OpenId。与字段 <see cref="GuideAccount"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_openid")]
        public string? GuideOpenId { get; set; }

        /// <summary>
        /// 获取或设置标签可选值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_values")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_values")]
        public IList<string> TagValues { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置本月还可主动发消息次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("push_count")]
        [System.Text.Json.Serialization.JsonPropertyName("push_count")]
        public int? PushCount { get; set; }
    }
}
