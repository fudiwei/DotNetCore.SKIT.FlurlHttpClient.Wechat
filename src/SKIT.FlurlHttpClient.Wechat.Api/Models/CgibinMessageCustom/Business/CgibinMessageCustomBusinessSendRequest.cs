namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/custom/business/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageCustomBusinessSendRequest : WechatApiRequest, IInferable<CgibinMessageCustomBusinessSendRequest, CgibinMessageCustomBusinessSendResponse>
    {
        public static class Types
        {
            public class TextMessage : CgibinMessageCustomSendRequest.Types.TextMessage
            {
            }

            public class ImageMessage : CgibinMessageCustomSendRequest.Types.ImageMessage
            {
            }

            public class NewsMessage
            {
                public static class Types
                {
                    public class Article : CgibinMessageCustomSendRequest.Types.NewsMessage.Types.Article
                    {
                    }
                }

                /// <summary>
                /// 获取或设置图文链接列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("articles")]
                [System.Text.Json.Serialization.JsonPropertyName("articles")]
                public List<Types.Article>? ArticleList { get; set; }
            }

            public class MpNewsArticleMessage : CgibinMessageCustomSendRequest.Types.MpNewsArticleMessage
            {
            }

            public class LinkMessage : CgibinMessageCustomSendRequest.Types.LinkMessage
            {
            }

            public class VoiceMessage : CgibinMessageCustomSendRequest.Types.VoiceMessage
            {
            }

            public class VideoMessage : CgibinMessageCustomSendRequest.Types.VideoMessage
            {
            }

            public class MusicMessage : CgibinMessageCustomSendRequest.Types.MusicMessage
            {
            }

            public class CardMessage : CgibinMessageCustomSendRequest.Types.CardMessage
            {
            }

            public class MenuMessage : CgibinMessageCustomSendRequest.Types.__zz__MenuMessage
            {
                public static class Types
                {
                    public class MenuItem : CgibinMessageCustomSendRequest.Types.MenuMessage.Types.MenuItem
                    {
                    }
                }

                /// <summary>
                /// 获取或设置菜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public List<Types.MenuItem>? List { get; set; }
            }

            public class MiniProgramMessage : CgibinMessageCustomSendRequest.Types.MiniProgramMessage
            {
            }

            public class CustomService : CgibinMessageCustomSendRequest.Types.CustomService
            {
            }

            public class AIMessageContext : CgibinMessageCustomSendRequest.Types.AIMessageContext
            {
            }
        }

        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string? ToUserOpenId { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string? MessageType { get; set; }

        /// <summary>
        /// 获取或设置文本消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.TextMessage? MessageContentForText { get; set; }

        /// <summary>
        /// 获取或设置图文链接消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("news")]
        [System.Text.Json.Serialization.JsonPropertyName("news")]
        public Types.NewsMessage? MessageContentForNews { get; set; }

        /// <summary>
        /// 获取或设置图文消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnewsarticle")]
        [System.Text.Json.Serialization.JsonPropertyName("mpnewsarticle")]
        public Types.MpNewsArticleMessage? MessageContentForMpNewsArticle { get; set; }

        /// <summary>
        /// 获取或设置图文链接消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public Types.LinkMessage? MessageContentForLink { get; set; }

        /// <summary>
        /// 获取或设置图片消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageMessage? MessageContentForImage { get; set; }

        /// <summary>
        /// 获取或设置语音消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice")]
        [System.Text.Json.Serialization.JsonPropertyName("voice")]
        public Types.VoiceMessage? MessageContentForVoice { get; set; }

        /// <summary>
        /// 获取或设置视频消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video")]
        [System.Text.Json.Serialization.JsonPropertyName("video")]
        public Types.VideoMessage? MessageContentForVideo { get; set; }

        /// <summary>
        /// 获取或设置音乐消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("music")]
        [System.Text.Json.Serialization.JsonPropertyName("music")]
        public Types.MusicMessage? MessageContentForMusic { get; set; }

        /// <summary>
        /// 获取或设置卡券消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxcard")]
        [System.Text.Json.Serialization.JsonPropertyName("wxcard")]
        public Types.CardMessage? MessageContentForCard { get; set; }

        /// <summary>
        /// 获取或设置菜单消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgmenu")]
        [System.Text.Json.Serialization.JsonPropertyName("msgmenu")]
        public Types.MenuMessage? MessageContentForMenu { get; set; }

        /// <summary>
        /// 获取或设置小程序消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogrampage")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogrampage")]
        public Types.MiniProgramMessage? MessageContentForMiniProgram { get; set; }

        /// <summary>
        /// 获取或设置客服子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("businessid")]
        [System.Text.Json.Serialization.JsonPropertyName("businessid")]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 获取或设置客服帐号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customservice")]
        [System.Text.Json.Serialization.JsonPropertyName("customservice")]
        public Types.CustomService? CustomService { get; set; }

        /// <summary>
        /// 获取或设置 AI 消息上下文信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aimsgcontext")]
        [System.Text.Json.Serialization.JsonPropertyName("aimsgcontext")]
        public Types.AIMessageContext? AIMessageContext { get; set; }
    }
}
