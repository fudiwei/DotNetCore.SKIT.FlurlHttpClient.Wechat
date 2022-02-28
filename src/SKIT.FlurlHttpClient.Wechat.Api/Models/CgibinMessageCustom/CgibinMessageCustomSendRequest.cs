using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/custom/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageCustomSendRequest : WechatApiRequest, IInferable<CgibinMessageCustomSendRequest, CgibinMessageCustomSendResponse>
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

            public class MpNewsMessage : ImageMessage
            {
            }

            public class NewsMessage
            {
                public static class Types
                {
                    public class Article
                    {
                        /// <summary>
                        /// 获取或设置图文链接标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文链接描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文链接被点击后跳转的链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文链接的图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("picurl")]
                        [System.Text.Json.Serialization.JsonPropertyName("picurl")]
                        public string PictureUrl { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置图文链接列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("articles")]
                [System.Text.Json.Serialization.JsonPropertyName("articles")]
                public IList<Types.Article> ArticleList { get; set; } = new List<Types.Article>();
            }

            public class MpNewsArticleMessage
            {
                /// <summary>
                /// 获取或设置图文消息的 ArticleId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("article_id")]
                [System.Text.Json.Serialization.JsonPropertyName("article_id")]
                public string ArticleId { get; set; } = string.Empty;
            }

            public class LinkMessage
            {
                /// <summary>
                /// 获取或设置图文链接标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文链接描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文链接被点击后跳转的链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文链接的图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_url")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_url")]
                public string ThumbnailUrl { get; set; } = string.Empty;
            }

            public class VoiceMessage : ImageMessage
            {
            }

            public class VideoMessage : ImageMessage
            {
                /// <summary>
                /// 获取或设置视频缩略图媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                public string ThumbnailMediaId { get; set; } = string.Empty;

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

            public class MusicMessage
            {
                /// <summary>
                /// 获取或设置音乐缩略图媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                public string ThumbnailMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置音乐 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("musicurl")]
                [System.Text.Json.Serialization.JsonPropertyName("musicurl")]
                public string MusicUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置高品质音乐 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hqmusicurl")]
                [System.Text.Json.Serialization.JsonPropertyName("hqmusicurl")]
                public string? HQMusicUrl { get; set; }

                /// <summary>
                /// 获取或设置音乐标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置音乐描述。
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
            }

            public class MenuMessage
            {
                public static class Types
                {
                    public class MenuItem
                    {
                        /// <summary>
                        /// 获取或设置菜单项 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置菜单项内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置头部内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_content")]
                [System.Text.Json.Serialization.JsonPropertyName("head_content")]
                public string? HeadContent { get; set; }

                /// <summary>
                /// 获取或设置菜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public IList<Types.MenuItem> List { get; set; } = new List<Types.MenuItem>();

                /// <summary>
                /// 获取或设置尾部内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tail_content")]
                [System.Text.Json.Serialization.JsonPropertyName("tail_content")]
                public string? TailContent { get; set; }
            }

            public class MiniProgramMessage
            {
                /// <summary>
                /// 获取或设置小程序缩略图媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                public string? ThumbnailMediaId { get; set; }

                /// <summary>
                /// 获取或设置小程序标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

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
            }

            public class CustomService
            {
                /// <summary>
                /// 获取或设置客服账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_account")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
                public string? KfAccount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息类型。
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
        [Obsolete("相关接口或字段于 2021-12-31 下线。")]
        [Newtonsoft.Json.JsonProperty("mpnews")]
        [System.Text.Json.Serialization.JsonPropertyName("mpnews")]
        public Types.MpNewsMessage? MessageContentForMpNews { get; set; }

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
        /// 获取或设置客服帐号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customservice")]
        [System.Text.Json.Serialization.JsonPropertyName("customservice")]
        public Types.CustomService? CustomService { get; set; }
    }
}
