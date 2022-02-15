using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/mass/sendall 接口的请求。</para>
    /// </summary>
    public class CgibinMessageMassSendAllRequest : WechatApiRequest, IMapResponse<CgibinMessageMassSendAllRequest, CgibinMessageMassSendAllResponse>
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置是否向全部用户发送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_to_all")]
                [System.Text.Json.Serialization.JsonPropertyName("is_to_all")]
                public bool? IsToAll { get; set; }

                /// <summary>
                /// 获取或设置群发到的标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_id")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                public int? TagId { get; set; }
            }

            public class TextMessage : CgibinMessageMassSendRequest.Types.TextMessage
            {
            }

            public class ImagesMessage : CgibinMessageMassSendRequest.Types.ImagesMessage
            {
            }

            public class MpNewsMessage : CgibinMessageMassSendRequest.Types.MpNewsMessage
            {
            }

            public class VoiceMessage : CgibinMessageMassSendRequest.Types.VoiceMessage
            {
            }

            public class VideoMessage : CgibinMessageMassSendRequest.Types.VideoMessage
            {
            }

            public class CardMessage : CgibinMessageMassSendRequest.Types.CardMessage
            {
            }
        }

        /// <summary>
        /// 获取或设置接收者过滤器。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter")]
        [System.Text.Json.Serialization.JsonPropertyName("filter")]
        public Types.Filter Filter { get; set; } = new Types.Filter();

        /// <summary>
        /// 获取或设置群发消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string MessageType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文本消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.TextMessage? MessageContentForText { get; set; }

        /// <summary>
        /// 获取或设置图文消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnews")]
        [System.Text.Json.Serialization.JsonPropertyName("mpnews")]
        public Types.MpNewsMessage? MessageContentForMpNews { get; set; }

        /// <summary>
        /// 获取或设置多张图片消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public Types.ImagesMessage? MessageContentForImages { get; set; }

        /// <summary>
        /// 获取或设置语音消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice")]
        [System.Text.Json.Serialization.JsonPropertyName("voice")]
        public Types.VoiceMessage? MessageContentForVoice { get; set; }

        /// <summary>
        /// 获取或设置视频消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpvideo")]
        [System.Text.Json.Serialization.JsonPropertyName("mpvideo")]
        public Types.VideoMessage? MessageContentForVideo { get; set; }

        /// <summary>
        /// 获取或设置卡券消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxcard")]
        [System.Text.Json.Serialization.JsonPropertyName("wxcard")]
        public Types.CardMessage? MessageContentForCard { get; set; }

        /// <summary>
        /// 获取或设置是否停止群发转载。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_ignore_reprint")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("send_ignore_reprint")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsIgnoreReprint { get; set; }

        /// <summary>
        /// 获取或设置开发者侧群发 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clientmsgid")]
        [System.Text.Json.Serialization.JsonPropertyName("clientmsgid")]
        public string? ClientMessageId { get; set; }
    }
}
