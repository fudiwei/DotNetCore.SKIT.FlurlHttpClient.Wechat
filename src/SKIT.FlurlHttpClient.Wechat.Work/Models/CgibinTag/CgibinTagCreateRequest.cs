using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tag/create 接口的请求。</para>
    /// </summary>
    public class CgibinTagCreateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
        public int? TagId { get; set; }

        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagname")]
        [System.Text.Json.Serialization.JsonPropertyName("tagname")]
        public string Name { get; set; } = string.Empty;
    }
}
