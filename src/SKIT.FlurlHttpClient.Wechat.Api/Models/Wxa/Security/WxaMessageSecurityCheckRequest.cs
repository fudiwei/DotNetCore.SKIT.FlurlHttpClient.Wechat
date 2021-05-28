using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/msg_sec_check 接口的请求。</para>
    /// </summary>
    public class WxaMessageSecurityCheckRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
