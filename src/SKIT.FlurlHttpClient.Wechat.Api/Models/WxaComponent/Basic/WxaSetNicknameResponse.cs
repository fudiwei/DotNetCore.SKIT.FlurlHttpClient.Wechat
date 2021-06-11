using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setnickname 接口的响应。</para>
    /// </summary>
    public class WxaSetNicknameResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        public int? AuditId { get; set; }

        /// <summary>
        /// 获取或设置材料说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wording")]
        [System.Text.Json.Serialization.JsonPropertyName("wording")]
        public string? Wording { get; set; }
    }
}
