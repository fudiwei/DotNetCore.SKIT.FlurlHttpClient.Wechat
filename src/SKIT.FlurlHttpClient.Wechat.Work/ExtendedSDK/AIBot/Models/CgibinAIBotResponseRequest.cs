namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/response 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotResponseRequest : WechatWorkAIBotRequest
    {
        public static class Types
        {
            public class Text
            {
                /// <summary>
                /// 获取或设置文本内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }

            public class Markdown
            {
                /// <summary>
                /// 获取或设置 Markdown 内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用户反馈信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feedback")]
                [System.Text.Json.Serialization.JsonPropertyName("feedback")]
                public Feedback? Feedback { get; set; }
            }

            public class TemplateCard
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
                        public string? IconUrl { get; set; }

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
                        public string? Title { get; set; }

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
                        public decimal? AspectRatio { get; set; }
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

                    public class ImageTextArea
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
                        /// 获取或设置左图右文样式的标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置左图右文样式的描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置左图右文样式的图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                        public string? ImageUrl { get; set; }
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
                        /// 获取或设置智能问答问题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question")]
                        [System.Text.Json.Serialization.JsonPropertyName("question")]
                        public string? Question { get; set; }

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
                                public bool? IsChecked { get; set; }
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
                /// 获取或设置左图右文信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_text_area")]
                [System.Text.Json.Serialization.JsonPropertyName("image_text_area")]
                public Types.ImageTextArea? ImageTextArea { get; set; }

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
                /// 获取或设置下拉选择按钮信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("button_selection")]
                [System.Text.Json.Serialization.JsonPropertyName("button_selection")]
                public Types.Select? ButtonSelection { get; set; }

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

                /// <summary>
                /// 获取或设置用户交互反馈信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feedback")]
                [System.Text.Json.Serialization.JsonPropertyName("feedback")]
                public Feedback? Feedback { get; set; }
            }

            public class Feedback
            {
                /// <summary>
                /// 获取或设置反馈 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string? Id { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置主动回复临时 URL。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ResponseUrl { get; set; } = string.Empty;

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
        public Types.Text? Text { get; set; }

        /// <summary>
        /// 获取或设置 Markdown 消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("markdown")]
        [System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public Types.Markdown? Markdown { get; set; }

        /// <summary>
        /// 获取或设置模板卡片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_card")]
        [System.Text.Json.Serialization.JsonPropertyName("template_card")]
        public Types.TemplateCard? TemplateCard { get; set; }
    }
}
