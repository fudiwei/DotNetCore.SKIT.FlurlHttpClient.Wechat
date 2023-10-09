using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models
{
    /// <summary>
    /// <para>表示会话内容存档之解密会话记录数据接口的响应。</para>
    /// </summary>
    public class DecryptChatRecordResponse : WechatWorkFinanceResponse
    {
        public static class Types
        {
            public class TextMessage : Abstractions.TextMessage
            {
            }

            public class ImageMessage : Abstractions.ImageMessage
            {
            }

            public class RevokeMessage : Abstractions.RevokeMessage
            {
            }

            public class AgreeMessage : Abstractions.AgreeMessage
            {
            }

            public class VoiceMessage : Abstractions.VoiceMessage
            {
            }

            public class VideoMessage : Abstractions.VideoMessage
            {
            }

            public class BusinessCardMessage : Abstractions.BusinessCardMessage
            {
            }

            public class LocationMessage : Abstractions.LocationMessage
            {
            }

            public class EmotionMessage : Abstractions.EmotionMessage
            {
            }

            public class FileMessage : Abstractions.FileMessage
            {
            }

            public class LinkMessage : Abstractions.LinkMessage
            {
            }

            public class MiniProgramMessage : Abstractions.MiniProgramMessage
            {
            }

            public class ChatRecordMessage : Abstractions.ChatRecordMessage
            {
            }

            public class TodoMessage : Abstractions.TodoMessage
            {
            }

            public class VoteMessage : Abstractions.VoteMessage
            {
            }

            public class CollectMessage : Abstractions.CollectMessage
            {
            }

            public class RedPacketMessage : Abstractions.RedPacketMessage
            {
            }

            public class MeetingMessage : Abstractions.MeetingMessage
            {
            }

            public class DocumentMessage : Abstractions.DocumentMessage
            {
            }

            public class InfoMessage : Abstractions.InfoMessage
            {
            }

            public class CalendarMessage : Abstractions.CalendarMessage
            {
            }

            public class MixedMessage : Abstractions.MixedMessage
            {
            }

            public class MeetingVoiceCallMessage : Abstractions.MeetingVoiceCallMessage
            {
            }

            public class VoIPDocumentShareMessage : Abstractions.VoIPDocumentShareMessage
            {
            }

            public class ChannelsFeedMessage : Abstractions.ChannelsFeedMessage
            {
            }
        }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息动作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息发送方 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? FromUserId { get; set; }

        /// <summary>
        /// 获取或设置消息接收方 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tolist")]
        [System.Text.Json.Serialization.JsonPropertyName("tolist")]
        public string[]? ToUserIdList { get; set; }

        /// <summary>
        /// 获取或设置群聊房间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomid")]
        [System.Text.Json.Serialization.JsonPropertyName("roomid")]
        public string? RoomId { get; set; }

        /// <summary>
        /// 获取或设置消息发送毫秒级时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtime")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtime")]
        public long MessageTimeMilliseconds { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string MessageType { get; set; } = default!;

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
        /// 获取或设置撤回消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revoke")]
        [System.Text.Json.Serialization.JsonPropertyName("revoke")]
        public Types.RevokeMessage? MessageContentAsRevoke { get; set; }

        /// <summary>
        /// 获取或设置同意/不同意消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agree")]
        [System.Text.Json.Serialization.JsonPropertyName("agree")]
        public Types.AgreeMessage? MessageContentAsAgree { get; set; }

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
        /// 获取或设置名片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card")]
        [System.Text.Json.Serialization.JsonPropertyName("card")]
        public Types.BusinessCardMessage? MessageContentAsBusinessCard { get; set; }

        /// <summary>
        /// 获取或设置位置消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public Types.LocationMessage? MessageContentAsLocation { get; set; }

        /// <summary>
        /// 获取或设置表情消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emotion")]
        [System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public Types.EmotionMessage? MessageContentAsEmotion { get; set; }

        /// <summary>
        /// 获取或设置文件消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file")]
        [System.Text.Json.Serialization.JsonPropertyName("file")]
        public Types.FileMessage? MessageContentAsFile { get; set; }

        /// <summary>
        /// 获取或设置图文链接消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public Types.LinkMessage? MessageContentAsLink { get; set; }

        /// <summary>
        /// 获取或设置小程序消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weapp")]
        [System.Text.Json.Serialization.JsonPropertyName("weapp")]
        public Types.MiniProgramMessage? MessageContentAsMiniProgram { get; set; }

        /// <summary>
        /// 获取或设置会话记录消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatrecord")]
        [System.Text.Json.Serialization.JsonPropertyName("chatrecord")]
        public Types.ChatRecordMessage? MessageContentAsChatRecord { get; set; }

        /// <summary>
        /// 获取或设置待办消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("todo")]
        [System.Text.Json.Serialization.JsonPropertyName("todo")]
        public Types.TodoMessage? MessageContentAsTodo { get; set; }

        /// <summary>
        /// 获取或设置投票消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vote")]
        [System.Text.Json.Serialization.JsonPropertyName("vote")]
        public Types.VoteMessage? MessageContentAsVote { get; set; }

        /// <summary>
        /// 获取或设置填表消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collect")]
        [System.Text.Json.Serialization.JsonPropertyName("collect")]
        public Types.CollectMessage? MessageContentAsCollect { get; set; }

        /// <summary>
        /// 获取或设置红包消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redpacket")]
        [System.Text.Json.Serialization.JsonPropertyName("redpacket")]
        public Types.RedPacketMessage? MessageContentAsRedPacket { get; set; }

        /// <summary>
        /// 获取或设置会议消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting")]
        public Types.MeetingMessage? MessageContentAsMeeting { get; set; }

        /// <summary>
        /// 获取或设置在线文档消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("doc")]
        [System.Text.Json.Serialization.JsonPropertyName("doc")]
        public Types.DocumentMessage? MessageContentAsDocument { get; set; }

        /// <summary>
        /// 获取或设置 Markdown、图文消息或音视频通话信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.InfoMessage? MessageContentAsInfo { get; set; }

        /// <summary>
        /// 获取或设置日程消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar")]
        public Types.CalendarMessage? MessageContentAsCalendar { get; set; }

        /// <summary>
        /// 获取或设置混合消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mixed")]
        [System.Text.Json.Serialization.JsonPropertyName("mixed")]
        public Types.MixedMessage? MessageContentAsMixed { get; set; }

        /// <summary>
        /// 获取或设置会议音频存档消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_voice_call")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_voice_call")]
        public Types.MeetingVoiceCallMessage? MessageContentAsMeetingVoiceCall { get; set; }

        /// <summary>
        /// 获取或设置 VoIP 音频存档消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voip_doc_share")]
        [System.Text.Json.Serialization.JsonPropertyName("voip_doc_share")]
        public Types.VoIPDocumentShareMessage? MessageContentAsVoIPDocumentShare { get; set; }

        /// <summary>
        /// 获取或设置视频号消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sphfeed")]
        [System.Text.Json.Serialization.JsonPropertyName("sphfeed")]
        public Types.ChannelsFeedMessage? MessageContentAsChannelsFeed { get; set; }

        /// <summary>
        /// 获取或设置音频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voiceid")]
        [System.Text.Json.Serialization.JsonPropertyName("voiceid")]
        public string? VoiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 VoIP ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voipid")]
        [System.Text.Json.Serialization.JsonPropertyName("voipid")]
        public string? VoIPId { get; set; } = default!;

        /// <summary>
        /// 获取或设置扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonExtensionData]
        [System.Text.Json.Serialization.JsonExtensionData]
        public IDictionary<string, object>? ExtensionData { get; set; }
    }
}
