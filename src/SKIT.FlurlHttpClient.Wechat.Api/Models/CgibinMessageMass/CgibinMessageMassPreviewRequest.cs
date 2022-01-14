using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/mass/preview 接口的请求。</para>
    /// </summary>
    public class CgibinMessageMassPreviewRequest : WechatApiRequest
    {
        public static class Types
        {
            public class TextMessage
            {
                /// <summary>
                /// 获取或设置文本内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }

            public class ImageMessage
            {
                /// <summary>
                /// 获取或设置媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = string.Empty;
            }

            public class ImagesMessage
            {
                /// <summary>
                /// 获取或设置媒体文件标识列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("media_ids")]
                public IList<string> MediaIdList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置推荐语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recommend")]
                [System.Text.Json.Serialization.JsonPropertyName("recommend")]
                public string? Recommend { get; set; }

                /// <summary>
                /// 获取或设置是否打开评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_open_comment")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("need_open_comment")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsOpenComment { get; set; }

                /// <summary>
                /// 获取或设置是否粉丝才可评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("only_fans_can_comment")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("only_fans_can_comment")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsOnlyFansCanComment { get; set; }
            }

            public class MpNewsMessage : ImageMessage
            {
            }

            public class VoiceMessage : ImageMessage
            {
            }

            public class VideoMessage : ImageMessage
            {
                /// <summary>
                /// 获取或设置视频标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置视频描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }
            }

            public class CardMessage
            {
                /// <summary>
                /// 获取或设置卡券模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string CardId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置卡券扩展属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_ext")]
                [System.Text.Json.Serialization.JsonPropertyName("card_ext")]
                public string? CardExtra { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string? ToUserOpenId { get; set; }

        /// <summary>
        /// 获取或设置接收消息的用户微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("towxname")]
        [System.Text.Json.Serialization.JsonPropertyName("towxname")]
        public string? ToUserWxname { get; set; }

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
        /// 获取或设置图片消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageMessage? MessageContentForImage { get; set; }

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
    }
}
