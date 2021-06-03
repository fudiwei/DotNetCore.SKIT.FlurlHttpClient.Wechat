using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/message/send 接口的请求。</para>
    /// </summary>
    public class CgibinLinkedCorpMessageSendRequest : WechatWorkRequest
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

            public class MiniProgramNoticeMessage : CgibinMessageSendRequest.Types.MiniProgramNoticeMessage
            {
            }
        }

        /// <summary>
        /// 获取或设置接收消息的互联企业成员账号（格式："CorpId/UserId"）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public IList<string>? ToCorpUserIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息的互联企业部门 ID（格式："LinkedId/DepartmentId"）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toparty")]
        [System.Text.Json.Serialization.JsonPropertyName("toparty")]
        public IList<string>? ToLinkedDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totag")]
        [System.Text.Json.Serialization.JsonPropertyName("totag")]
        public IList<int>? ToTagIdList { get; set; }

        /// <summary>
        /// 获取或设置是否发送给应用可见范围内的所有人，包括互联企业的成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toall")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("toall")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
        public bool? IsToAll { get; set; }

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
        public Types.TextMessage? MessageContentForText { get; set; }

        /// <summary>
        /// 获取或设置图片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageMessage? MessageContentForImage { get; set; }

        /// <summary>
        /// 获取或设置语音消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice")]
        [System.Text.Json.Serialization.JsonPropertyName("voice")]
        public Types.VoiceMessage? MessageContentForVoice { get; set; }

        /// <summary>
        /// 获取或设置视频消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video")]
        [System.Text.Json.Serialization.JsonPropertyName("video")]
        public Types.VideoMessage? MessageContentForVideo { get; set; }

        /// <summary>
        /// 获取或设置文件消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file")]
        [System.Text.Json.Serialization.JsonPropertyName("file")]
        public Types.FileMessage? MessageContentForFile { get; set; }

        /// <summary>
        /// 获取或设置文本卡片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("textcard")]
        [System.Text.Json.Serialization.JsonPropertyName("textcard")]
        public Types.TextCardMessage? MessageContentForTextCard { get; set; }

        /// <summary>
        /// 获取或设置图文消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("news")]
        [System.Text.Json.Serialization.JsonPropertyName("news")]
        public Types.NewsMessage? MessageContentForNews { get; set; }

        /// <summary>
        /// 获取或设置图文消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnews")]
        [System.Text.Json.Serialization.JsonPropertyName("mpnews")]
        public Types.MpNewsMessage? MessageContentForMpNews { get; set; }

        /// <summary>
        /// 获取或设置 Markdown 消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("markdown")]
        [System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public Types.MarkdownMessage? MessageContentForMarkdown { get; set; }

        /// <summary>
        /// 获取或设置小程序通知消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_notice")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_notice")]
        public Types.MiniProgramNoticeMessage? MessageContentForMiniProgramNotice { get; set; }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置是否是保密消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("safe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("safe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
        public bool? IsSafe { get; set; }
    }
}
