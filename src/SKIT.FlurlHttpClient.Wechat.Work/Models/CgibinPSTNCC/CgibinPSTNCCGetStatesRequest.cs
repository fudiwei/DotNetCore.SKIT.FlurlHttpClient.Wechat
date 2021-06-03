using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/pstncc/getstates 接口的请求。</para>
    /// </summary>
    public class CgibinPSTNCCGetStatesRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置呼叫的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callee_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("callee_userid")]
        public string CalleeUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置呼叫 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callid")]
        [System.Text.Json.Serialization.JsonPropertyName("callid")]
        public string CallId { get; set; } = string.Empty;
    }
}
