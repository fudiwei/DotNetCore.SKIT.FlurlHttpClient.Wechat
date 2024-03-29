﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/send_msg_on_event 接口的响应。</para>
    /// </summary>
    public class CgibinKfSendMessageOnEventResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string MessageId { get; set; } = default!;
    }
}
