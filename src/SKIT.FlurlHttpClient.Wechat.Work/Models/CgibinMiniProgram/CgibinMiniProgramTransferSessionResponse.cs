using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniprogram/transfer_session 接口的响应。</para>
    /// </summary>
    public class CgibinMiniProgramTransferSessionResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置下级企业的用户账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置下级企业的会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        [System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string SessionKey { get; set; } = default!;
    }
}
