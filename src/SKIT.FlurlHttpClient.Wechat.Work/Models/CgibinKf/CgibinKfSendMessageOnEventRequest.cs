namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/send_msg_on_event 接口的请求。</para>
    /// </summary>
    public class CgibinKfSendMessageOnEventRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class TextMessage : CgibinKfSendMessageRequest.Types.TextMessage
            {
            }

            public class MenuMessage : CgibinKfSendMessageRequest.Types.MenuMessage
            {
            }
        }

        /// <summary>
        /// 获取或设置事件响应消息对用的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string MessageCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string? MessageId { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string MessageType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.TextMessage? MessageContentAsText { get; set; }

        /// <summary>
        /// 获取或设置菜单消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgmenu")]
        [System.Text.Json.Serialization.JsonPropertyName("msgmenu")]
        public Types.MenuMessage? MessageContentAsMenu { get; set; }
    }
}
