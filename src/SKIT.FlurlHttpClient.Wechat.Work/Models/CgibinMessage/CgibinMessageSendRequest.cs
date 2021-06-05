using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageSendRequest : WechatWorkRequest
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
                /// 获取或设置图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = string.Empty;
            }

            public class VoiceMessage
            {
                /// <summary>
                /// 获取或设置语音 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = string.Empty;
            }

            public class VideoMessage
            {
                /// <summary>
                /// 获取或设置视频 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = string.Empty;

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

            public class FileMessage
            {
                /// <summary>
                /// 获取或设置文件 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = string.Empty;
            }

            public class TextCardMessage
            {
                /// <summary>
                /// 获取或设置点击后跳转的链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置卡片标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置卡片描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置按钮文字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("btntxt")]
                [System.Text.Json.Serialization.JsonPropertyName("btntxt")]
                public string? ButtonText { get; set; }
            }

            public class NewsMessage
            {
                public static class Types
                {
                    public class Article
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
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置图文封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("picurl")]
                        [System.Text.Json.Serialization.JsonPropertyName("picurl")]
                        public string? PictureUrl { get; set; }

                        /// <summary>
                        /// 获取或设置按钮文字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("btntxt")]
                        [System.Text.Json.Serialization.JsonPropertyName("btntxt")]
                        public string? ButtonText { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置图文消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("articles")]
                [System.Text.Json.Serialization.JsonPropertyName("articles")]
                public IList<Types.Article> ArticleList { get; set; } = new List<Types.Article>();
            }

            public class MpNewsMessage
            {
                public static class Types
                {
                    public class Article
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
                        /// 获取或设置图文摘要。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("digest")]
                        [System.Text.Json.Serialization.JsonPropertyName("digest")]
                        public string? Digest { get; set; }

                        /// <summary>
                        /// 获取或设置图文作者。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author")]
                        [System.Text.Json.Serialization.JsonPropertyName("author")]
                        public string? Author { get; set; }

                        /// <summary>
                        /// 获取或设置图文内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文原文链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_source_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_source_url")]
                        public string? ContentSourceUrl { get; set; }

                        /// <summary>
                        /// 获取或设置图文封面 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                        public string? ThumbnailMediaId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置图文消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("articles")]
                [System.Text.Json.Serialization.JsonPropertyName("articles")]
                public IList<Types.Article> ArticleList { get; set; } = new List<Types.Article>();
            }

            public class MarkdownMessage
            {
                /// <summary>
                /// 获取或设置 Markdown 内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }

            public class MiniProgramNoticeMessage
            {
                public static class Types
                {
                    public class KeyValue
                    {
                        /// <summary>
                        /// 获取或设置消息内容的 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置消息内容的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public string PagePath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置消息内容键值对列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_item")]
                [System.Text.Json.Serialization.JsonPropertyName("content_item")]
                public IList<Types.KeyValue>? ContentKeyValueList { get; set; }

                /// <summary>
                /// 获取或设置是否放大第一个消息内容键值对。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("emphasis_first_item")]
                [System.Text.Json.Serialization.JsonPropertyName("emphasis_first_item")]
                public bool? IsFirstItemEmphasised { get; set; }
            }

            public class TaskCardMessage
            {
                public static class Types
                {
                    public class Button
                    {
                        /// <summary>
                        /// 获取或设置按钮 Key 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置按钮名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置按钮颜色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("color")]
                        [System.Text.Json.Serialization.JsonPropertyName("color")]
                        public string? Color { get; set; }

                        /// <summary>
                        /// 获取或设置按钮字体是否加粗。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_bold")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_bold")]
                        public bool? IsBold { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string TaskId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置点击后跳转的链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置卡片标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置卡片描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置按钮列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("btn")]
                [System.Text.Json.Serialization.JsonPropertyName("btn")]
                public IList<Types.Button> ButtonList { get; set; } = new List<Types.Button>();
            }

            public class TemplateMessage
            {
                public static class Types
                {
                    public class KeyValue
                    {
                        /// <summary>
                        /// 获取或设置消息内容的 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置消息内容的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置点击模板消息后的跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置消息内容键值对。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_item")]
                [System.Text.Json.Serialization.JsonPropertyName("content_item")]
                public IList<Types.KeyValue> ContentItemList { get; set; } = new List<Types.KeyValue>();
            }
        }

        /// <summary>
        /// 获取或设置接收消息的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.SeparatedByVBarStringIListConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.SeparatedByVBarStringIListConverter))]
        public IList<string>? ToUserIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toparty")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.SeparatedByVBarInt32IListConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("toparty")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.SeparatedByVBarInt32IListConverter))]
        public IList<int>? ToDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.SeparatedByVBarInt32IListConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("totag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.SeparatedByVBarInt32IListConverter))]
        public IList<int>? ToTagIdList { get; set; }

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
        /// 获取或设置任务卡片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interactive_taskcard")]
        [System.Text.Json.Serialization.JsonPropertyName("interactive_taskcard")]
        public Types.TaskCardMessage? MessageContentForTaskCard { get; set; }

        /// <summary>
        /// 获取或设置模板消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("template_msg")]
        public Types.TemplateMessage? MessageContentForTemplate { get; set; }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置用户选择凭证列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_ticket_list")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_ticket_list")]
        public IList<string>? SelectedTicketList { get; set; }

        /// <summary>
        /// 获取或设置是否是保密消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("safe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("safe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
        public bool? IsSafe { get; set; }

        /// <summary>
        /// 获取或设置是否开启 ID 转译。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_id_trans")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable_id_trans")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
        public bool? EnableIdTransform { get; set; }

        /// <summary>
        /// 获取或设置是否开启重复消息检查。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_duplicate_check")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable_duplicate_check")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
        public bool? EnableDuplicateCheck { get; set; }

        /// <summary>
        /// 获取或设置重复消息检查的时间间隔（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_check_interval")]
        [System.Text.Json.Serialization.JsonPropertyName("duplicate_check_interval")]
        public int? DuplicateCheckInterval { get; set; }
    }
}
