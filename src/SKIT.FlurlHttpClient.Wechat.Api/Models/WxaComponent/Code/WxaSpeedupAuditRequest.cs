using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/speedupaudit 接口的请求。</para>
    /// </summary>
    public class WxaSpeedupAuditRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditid")]
        [System.Text.Json.Serialization.JsonPropertyName("auditid")]
        public int AuditId { get; set; }
    }
}
