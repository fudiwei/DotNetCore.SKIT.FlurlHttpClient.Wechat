using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/appchat/create 接口的响应。</para>
    /// </summary>
    public class CgibinAppChatCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置群聊 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatid")]
        [System.Text.Json.Serialization.JsonPropertyName("chatid")]
        public string ChatId { get; set; } = default!;
    }
}
