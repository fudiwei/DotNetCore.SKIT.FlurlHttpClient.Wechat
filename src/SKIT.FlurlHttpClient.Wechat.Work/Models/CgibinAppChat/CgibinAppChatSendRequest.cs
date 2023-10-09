namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/appchat/send 接口的请求。</para>
    /// </summary>
    public class CgibinAppChatSendRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class TextMessage : CgibinMessageSendRequest.Types.TextMessage
            {
            }

            public class ImageMessage : CgibinMessageSendRequest.Types.ImageMessage
            {
            }

            public class VoiceMessage : CgibinMessageSendRequest.Types.VoiceMessage
            {
            }

            public class VideoMessage : CgibinMessageSendRequest.Types.VideoMessage
            {
            }

            public class FileMessage : CgibinMessageSendRequest.Types.FileMessage
            {
            }

            public class TextCardMessage : CgibinMessageSendRequest.Types.TextCardMessage
            {
            }

            public class NewsMessage : CgibinMessageSendRequest.Types.NewsMessage
            {
            }

            public class MpNewsMessage : CgibinMessageSendRequest.Types.MpNewsMessage
            {
            }

            public class MarkdownMessage : CgibinMessageSendRequest.Types.MarkdownMessage
            {
            }
        }

        /// <summary>
        /// 获取或设置群聊 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatid")]
        [System.Text.Json.Serialization.JsonPropertyName("chatid")]
        public string ChatId { get; set; } = string.Empty;

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
        /// 获取或设置图片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageMessage? MessageContentAsImage { get; set; }

        /// <summary>
        /// 获取或设置语音消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice")]
        [System.Text.Json.Serialization.JsonPropertyName("voice")]
        public Types.VoiceMessage? MessageContentAsVoice { get; set; }

        /// <summary>
        /// 获取或设置视频消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video")]
        [System.Text.Json.Serialization.JsonPropertyName("video")]
        public Types.VideoMessage? MessageContentAsVideo { get; set; }

        /// <summary>
        /// 获取或设置文件消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file")]
        [System.Text.Json.Serialization.JsonPropertyName("file")]
        public Types.FileMessage? MessageContentAsFile { get; set; }

        /// <summary>
        /// 获取或设置文本卡片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("textcard")]
        [System.Text.Json.Serialization.JsonPropertyName("textcard")]
        public Types.TextCardMessage? MessageContentAsTextCard { get; set; }

        /// <summary>
        /// 获取或设置图文消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("news")]
        [System.Text.Json.Serialization.JsonPropertyName("news")]
        public Types.NewsMessage? MessageContentAsNews { get; set; }

        /// <summary>
        /// 获取或设置图文消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnews")]
        [System.Text.Json.Serialization.JsonPropertyName("mpnews")]
        public Types.MpNewsMessage? MessageContentAsMpNews { get; set; }

        /// <summary>
        /// 获取或设置 Markdown 消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("markdown")]
        [System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public Types.MarkdownMessage? MessageContentAsMarkdown { get; set; }

        /// <summary>
        /// 获取或设置是否是保密消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("safe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("safe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsSafe { get; set; }
    }
}
