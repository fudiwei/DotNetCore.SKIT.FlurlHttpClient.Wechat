﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/miniprogram/jscode2session 接口的响应。</para>
    /// </summary>
    public class CgibinServiceMiniProgramJsCode2SessionResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置用户所属企业 Corpid。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户所在企业内的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户所在企业内的会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        [System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string SessionKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置第三方成员唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
        public string OpenUserId { get; set; } = default!;
    }
}
