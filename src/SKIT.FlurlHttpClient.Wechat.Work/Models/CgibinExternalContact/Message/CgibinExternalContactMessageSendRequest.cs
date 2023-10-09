using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/message/send 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactMessageSendRequest : WechatWorkRequest
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

            public class MiniProgramMessage
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pagepath")]
                [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                public string PagePath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置小程序封面 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                public string? ThumbnailMediaId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置接收消息外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_external_user")]
        [System.Text.Json.Serialization.JsonPropertyName("to_external_user")]
        public IList<string>? ToExternalUserIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息家长账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_parent_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_parent_userid")]
        public IList<string>? ToParentUserIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息学生账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_student_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_student_userid")]
        public IList<string>? ToStudentUserIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息的部门 ID列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_party")]
        [System.Text.Json.Serialization.JsonPropertyName("to_party")]
        public IList<long>? ToDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置是否发送给学校的所有家长。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toall")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("toall")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
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
        /// 获取或设置小程序消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgramMessage? MessageContentAsMiniProgram { get; set; }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置是否开启 ID 转译。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_id_trans")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable_id_trans")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? EnableIdTransform { get; set; }

        /// <summary>
        /// 获取或设置是否开启重复消息检查。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_duplicate_check")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable_duplicate_check")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? EnableDuplicateCheck { get; set; }

        /// <summary>
        /// 获取或设置重复消息检查的时间间隔（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_check_interval")]
        [System.Text.Json.Serialization.JsonPropertyName("duplicate_check_interval")]
        public int? DuplicateCheckInterval { get; set; }
    }
}
