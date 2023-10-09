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

                        /// <summary>
                        /// 获取或设置跳转的小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置跳转的小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pagepath")]
                        [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                        public string? MiniProgramPagePath { get; set; }
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

            public class TemplateCardMessage
            {
                public static class Types
                {
                    public class Source
                    {
                        /// <summary>
                        /// 获取或设置来源图片的 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("icon_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("icon_url")]
                        public string IconUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置来源图片的描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置来源图片的描述颜色类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc_color")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc_color")]
                        public int? DescriptionColorType { get; set; }
                    }

                    public class MainTitle
                    {
                        /// <summary>
                        /// 获取或设置标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }
                    }

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图片的宽高比。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aspect_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
                        public double? AspectRatio { get; set; }
                    }

                    public class QuoteArea
                    {
                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// 获取或设置跳转链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置跳转小程序的 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置跳转小程序的路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pagepath")]
                        [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                        public string? MiniProgramPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置引用文献样式的标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置引用文献样式的引用文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quote_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("quote_text")]
                        public string? QuoteText { get; set; }
                    }

                    public class EmphasisContent : MainTitle
                    {
                    }

                    public class VerticalContent : MainTitle
                    {
                    }

                    public class HorizontalContent
                    {
                        /// <summary>
                        /// 获取或设置二级标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keyname")]
                        [System.Text.Json.Serialization.JsonPropertyName("keyname")]
                        public string Key { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置二级文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置链接类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// 获取或设置跳转链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置附件的 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string? MediaId { get; set; }

                        /// <summary>
                        /// 获取或设置成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string? UserId { get; set; }
                    }

                    public class Action
                    {
                        /// <summary>
                        /// 获取或设置跳转链接类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// 获取或设置跳转链接样式的文案内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置跳转链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置跳转小程序的 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置跳转小程序的路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pagepath")]
                        [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                        public string? MiniProgramPagePath { get; set; }
                    }

                    public class ActionMenu
                    {
                        public static class Types
                        {
                            public class Action
                            {
                                /// <summary>
                                /// 获取或设置操作按钮 Key。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("key")]
                                [System.Text.Json.Serialization.JsonPropertyName("key")]
                                public string Key { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置操作按钮文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string Text { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置菜单描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置操作按钮列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_list")]
                        public IList<Types.Action> ActionList { get; set; } = new List<Types.Action>();
                    }

                    public class Button
                    {
                        /// <summary>
                        /// 获取或设置按钮点击类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// 获取或设置按钮 Key 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string? Key { get; set; }

                        /// <summary>
                        /// 获取或设置按钮文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置按钮样式类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("style")]
                        [System.Text.Json.Serialization.JsonPropertyName("style")]
                        public int? Style { get; set; }

                        /// <summary>
                        /// 获取或设置按钮点击跳转 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }
                    }

                    public class Checkbox
                    {
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置选项 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选项文案描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string Text { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置是否要默认选中。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_checked")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_checked")]
                                public bool IsChecked { get; set; }

                                /// <summary>
                                /// 获取或设置是否可以选择。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("disable")]
                                [System.Text.Json.Serialization.JsonPropertyName("disable")]
                                public bool? IsDisabled { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置选择题 Key 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_key")]
                        public string QuestionKey { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置选择题模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("mode")]
                        public int? Mode { get; set; }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                        public IList<Types.Option> OptionList { get; set; } = new List<Types.Option>();

                        /// <summary>
                        /// 获取或设置是否可以选择。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("disable")]
                        [System.Text.Json.Serialization.JsonPropertyName("disable")]
                        public bool? IsDisabled { get; set; }
                    }

                    public class Select
                    {
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置选项 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选项文案描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string Text { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置是否可以选择。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("disable")]
                                [System.Text.Json.Serialization.JsonPropertyName("disable")]
                                public bool? IsDisabled { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置选择题 Key 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_key")]
                        public string QuestionKey { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置选择器标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置默认选定的选项 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("selected_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("selected_id")]
                        public string? SelectedOptoinId { get; set; }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                        public IList<Types.Option> OptionList { get; set; } = new List<Types.Option>();

                        /// <summary>
                        /// 获取或设置是否可以选择。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("disable")]
                        [System.Text.Json.Serialization.JsonPropertyName("disable")]
                        public bool? IsDisabled { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板卡片类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_type")]
                [System.Text.Json.Serialization.JsonPropertyName("card_type")]
                public string CardType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图片样式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_image")]
                [System.Text.Json.Serialization.JsonPropertyName("card_image")]
                public Types.Image? CardImage { get; set; }

                /// <summary>
                /// 获取或设置卡片来源样式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public Types.Source? Source { get; set; }

                /// <summary>
                /// 获取或设置一级标题信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("main_title")]
                [System.Text.Json.Serialization.JsonPropertyName("main_title")]
                public Types.MainTitle? MainTitle { get; set; }

                /// <summary>
                /// 获取或设置引用文献信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quote_area")]
                [System.Text.Json.Serialization.JsonPropertyName("quote_area")]
                public Types.QuoteArea? QuoteArea { get; set; }

                /// <summary>
                /// 获取或设置关键数据样式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("emphasis_content")]
                [System.Text.Json.Serialization.JsonPropertyName("emphasis_content")]
                public Types.EmphasisContent? EmphasisContent { get; set; }

                /// <summary>
                /// 获取或设置二级普通文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_title_text")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_title_text")]
                public string? SubTitleText { get; set; }

                /// <summary>
                /// 获取或设置二级垂直内容列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vertical_content_list")]
                [System.Text.Json.Serialization.JsonPropertyName("vertical_content_list")]
                public IList<Types.VerticalContent>? VerticalContentList { get; set; }

                /// <summary>
                /// 获取或设置二级文本列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("horizontal_content_list")]
                [System.Text.Json.Serialization.JsonPropertyName("horizontal_content_list")]
                public IList<Types.HorizontalContent>? HorizontalContentList { get; set; }

                /// <summary>
                /// 获取或设置跳转指引样式的列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_list")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_list")]
                public IList<Types.Action>? JumpActionList { get; set; }

                /// <summary>
                /// 获取或设置卡片的点击跳转事件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_action")]
                [System.Text.Json.Serialization.JsonPropertyName("card_action")]
                public Types.Action? Action { get; set; }

                /// <summary>
                /// 获取或设置卡片的右上角菜单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action_menu")]
                [System.Text.Json.Serialization.JsonPropertyName("action_menu")]
                public Types.ActionMenu? ActionMenu { get; set; }

                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string? TaskId { get; set; }

                /// <summary>
                /// 获取或设置按钮列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("button_list")]
                [System.Text.Json.Serialization.JsonPropertyName("button_list")]
                public IList<Types.Button>? ButtonList { get; set; }

                /// <summary>
                /// 获取或设置选择题信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkbox")]
                [System.Text.Json.Serialization.JsonPropertyName("checkbox")]
                public Types.Checkbox? Checkbox { get; set; }

                /// <summary>
                /// 获取或设置选择器列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("select_list")]
                [System.Text.Json.Serialization.JsonPropertyName("select_list")]
                public IList<Types.Select>? SelectList { get; set; }

                /// <summary>
                /// 获取或设置提交按钮列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("submit_button")]
                [System.Text.Json.Serialization.JsonPropertyName("submit_button")]
                public Types.Button? SubmitButton { get; set; }
            }

            public class TemplateMessage
            {
                public static class Types
                {
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
                    }

                    public class DataItem
                    {
                        /// <summary>
                        /// 获取或设置消息内容 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置消息内容文本。
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
                /// 获取或设置点击消息跳转的 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置点击消息跳转的小程序信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                public Types.MiniProgram? MiniProgram { get; set; }

                /// <summary>
                /// 获取或设置模板消息内容列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_item")]
                [System.Text.Json.Serialization.JsonPropertyName("content_item")]
                public IList<Types.DataItem>? DataList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置接收消息的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithPipeSplitConverter))]
        public IList<string>? ToUserIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toparty")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualLongListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("toparty")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualLongListWithPipeSplitConverter))]
        public IList<long>? ToDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置接收消息的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("totag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerListWithPipeSplitConverter))]
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
        /// 获取或设置小程序通知消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_notice")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_notice")]
        public Types.MiniProgramNoticeMessage? MessageContentAsMiniProgramNotice { get; set; }

        /// <summary>
        /// 获取或设置任务卡片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interactive_taskcard")]
        [System.Text.Json.Serialization.JsonPropertyName("interactive_taskcard")]
        public Types.TaskCardMessage? MessageContentAsTaskCard { get; set; }

        /// <summary>
        /// 获取或设置模板卡片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_card")]
        [System.Text.Json.Serialization.JsonPropertyName("template_card")]
        public Types.TemplateCardMessage? MessageContentAsTemplateCard { get; set; }

        /// <summary>
        /// 获取或设置模板信息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("template_msg")]
        public Types.TemplateMessage? MessageContentAsTemplate { get; set; }

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("safe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsSafe { get; set; }

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
