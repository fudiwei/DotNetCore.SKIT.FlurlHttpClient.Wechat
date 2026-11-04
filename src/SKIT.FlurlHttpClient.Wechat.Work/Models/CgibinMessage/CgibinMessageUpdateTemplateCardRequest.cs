namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/update_template_card 接口的请求。</para>
    /// </summary>
    public class CgibinMessageUpdateTemplateCardRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Button
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string? TaskId { get; set; }

                /// <summary>
                /// 获取或设置替换文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("replace_name")]
                [System.Text.Json.Serialization.JsonPropertyName("replace_name")]
                public string? ReplacementText { get; set; }
            }

            public class TemplateCardMessage : CgibinMessageSendRequest.Types.__zz__TemplateCardMessage
            {
                public static class Types
                {
                    public class Source : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.Source
                    {
                    }

                    public class MainTitle : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.MainTitle
                    {
                    }

                    public class Image : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.Image
                    {
                    }

                    public class QuoteArea : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.QuoteArea
                    {
                    }

                    public class EmphasisContent : MainTitle
                    {
                    }

                    public class VerticalContent : MainTitle
                    {
                    }

                    public class HorizontalContent : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.HorizontalContent
                    {
                    }

                    public class Action : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.Action
                    {
                    }

                    public class ActionMenu : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.__zz__ActionMenu
                    {
                        public static class Types
                        {
                            public class Action : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.ActionMenu.Types.Action
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置操作按钮列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_list")]
                        public List<Types.Action>? ActionList { get; set; }
                    }

                    public class Button : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.Button
                    {
                    }

                    public class Checkbox : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.__zz__Checkbox
                    {
                        public static class Types
                        {
                            public class Option : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.Checkbox.Types.Option
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                        public List<Types.Option>? OptionList { get; set; }
                    }

                    public class Select : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.__zz__Select
                    {
                        public static class Types
                        {
                            public class Option : CgibinMessageSendRequest.Types.TemplateCardMessage.Types.Select.Types.Option
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                        public List<Types.Option>? OptionList { get; set; }
                    }
                }

                /// <summary>
                /// /// 获取或设置按钮替换文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("replace_text")]
                [System.Text.Json.Serialization.JsonPropertyName("replace_text")]
                public string? ReplacementText { get; set; }

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
                /// 获取或设置二级垂直内容列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vertical_content_list")]
                [System.Text.Json.Serialization.JsonPropertyName("vertical_content_list")]
                public List<Types.VerticalContent>? VerticalContentList { get; set; }

                /// <summary>
                /// 获取或设置二级文本列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("horizontal_content_list")]
                [System.Text.Json.Serialization.JsonPropertyName("horizontal_content_list")]
                public List<Types.HorizontalContent>? HorizontalContentList { get; set; }

                /// <summary>
                /// 获取或设置跳转指引样式的列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_list")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_list")]
                public List<Types.Action>? JumpActionList { get; set; }

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
                /// 获取或设置按钮列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("button_list")]
                [System.Text.Json.Serialization.JsonPropertyName("button_list")]
                public List<Types.Button>? ButtonList { get; set; }

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
                public List<Types.Select>? SelectList { get; set; }

                /// <summary>
                /// 获取或设置提交按钮列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("submit_button")]
                [System.Text.Json.Serialization.JsonPropertyName("submit_button")]
                public Types.Button? SubmitButton { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userids")]
        [System.Text.Json.Serialization.JsonPropertyName("userids")]
        public List<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partyids")]
        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
        public List<long>? DepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagids")]
        [System.Text.Json.Serialization.JsonPropertyName("tagids")]
        public List<int>? TagIdList { get; set; }

        /// <summary>
        /// 获取或设置是否更新整个任务接收人员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atall")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("atall")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool? IsAtAll { get; set; }

        /// <summary>
        /// 获取或设置更新卡片所需要消费的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_code")]
        [System.Text.Json.Serialization.JsonPropertyName("response_code")]
        public string? ResponseCode { get; set; }

        /// <summary>
        /// 获取或设置是否开启 ID 转译。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_id_trans")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable_id_trans")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool? IsEnableIdTranslation { get; set; }

        /// <summary>
        /// 获取或设置按钮信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public Types.Button? Button { get; set; }

        /// <summary>
        /// 获取或设置模板卡片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_card")]
        [System.Text.Json.Serialization.JsonPropertyName("template_card")]
        public Types.TemplateCardMessage? TemplateCard { get; set; }
    }
}
