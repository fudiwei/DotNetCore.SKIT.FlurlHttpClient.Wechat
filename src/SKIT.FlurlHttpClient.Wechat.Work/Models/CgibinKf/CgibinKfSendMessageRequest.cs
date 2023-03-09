using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/send_msg 接口的请求。</para>
    /// </summary>
    public class CgibinKfSendMessageRequest : WechatWorkRequest
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

            public class LinkMessage
            {
                /// <summary>
                /// 获取或设置点击后跳转的链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图文描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置图文封面的 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                public string ThumbnailMediaId { get; set; } = string.Empty;
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
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序封面的 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                public string ThumbnailMediaId { get; set; } = string.Empty;
            }

            public class MenuMessage
            {
                public static class Types
                {
                    public class MenuItem
                    {
                        public static class Types
                        {
                            public class Text
                            {
                                /// <summary>
                                /// 获取或设置菜单项内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string Content { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置内容后面是否不换行。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("no_newline")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("no_newline")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                                public bool? IsNoNewline { get; set; }
                            }

                            public class Click
                            {
                                /// <summary>
                                /// 获取或设置点击项 ID。
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

                            public class View
                            {
                                /// <summary>
                                /// 获取或设置点击后跳转的链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置菜单项内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string Content { get; set; } = string.Empty;
                            }

                            public class MiniProgram
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
                                /// 获取或设置菜单项内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string Content { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置菜单类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Types.Text? Text { get; set; }

                        /// <summary>
                        /// 获取或设置点击项信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("click")]
                        [System.Text.Json.Serialization.JsonPropertyName("click")]
                        public Types.Click? Click { get; set; }

                        /// <summary>
                        /// 获取或设置跳转项信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view")]
                        [System.Text.Json.Serialization.JsonPropertyName("view")]
                        public Types.View? View { get; set; }

                        /// <summary>
                        /// 获取或设置小程序项信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("miniprogram")]
                        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                        public Types.MiniProgram? MiniProgram { get; set; }
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

            public class LocationMessage
            {
                /// <summary>
                /// 获取或设置纬度坐标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latitude")]
                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                public double Latitude { get; set; }

                /// <summary>
                /// 获取或设置经度坐标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("longitude")]
                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                public double Longitude { get; set; }

                /// <summary>
                /// 获取或设置位置名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }
            }

            public class BusinessCardMessage
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置客服账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_kfid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
        public string OpenKfId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收消息的外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string ToExternalUserId { get; set; } = string.Empty;

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
        /// 获取或设置图文链接消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public Types.LinkMessage? MessageContentForLink { get; set; }

        /// <summary>
        /// 获取或设置小程序消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgramMessage? MessageContentForMiniProgram { get; set; }

        /// <summary>
        /// 获取或设置菜单消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgmenu")]
        [System.Text.Json.Serialization.JsonPropertyName("msgmenu")]
        public Types.MenuMessage? MessageContentForMenu { get; set; }

        /// <summary>
        /// 获取或设置地理位置消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public Types.LocationMessage? MessageContentForLocation { get; set; }

        /// <summary>
        /// 获取或设置名片消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_card")]
        [System.Text.Json.Serialization.JsonPropertyName("business_card")]
        public Types.BusinessCardMessage? MessageContentForBusinessCard { get; set; }
    }
}
