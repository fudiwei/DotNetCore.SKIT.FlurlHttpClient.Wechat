using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/modify_form 接口的请求。</para>
    /// </summary>
    public class CgibinWedocModifyFormRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Form
            {
                public static class Types
                {
                    public class QuestionList : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionList
                    {
                        /// <summary>
                        /// 获取或设置问题列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("items")]
                        [System.Text.Json.Serialization.JsonPropertyName("items")]
                        public new IList<QuestionItem> Items { get; set; } = new List<QuestionItem>();
                    }

                    public class QuestionItem : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem
                    {
                        public static new class Types
                        {
                            public class Option : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.Option
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_item")]
                        public new IList<Types.Option>? OptionList { get; set; }
                    }

                    public class Settings : CgibinWedocCreateFormRequest.Types.Form.Types.Settings
                    {
                        public static new class Types
                        {
                            public class FillInRange : CgibinWedocCreateFormRequest.Types.Form.Types.Settings.Types.FillInRange
                            {
                            }

                            public class ManagerRange : CgibinWedocCreateFormRequest.Types.Form.Types.Settings.Types.ManagerRange
                            {
                            }

                            public class Repetition : CgibinWedocCreateFormRequest.Types.Form.Types.Settings.Types.Repetition
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置填写范围信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fill_in_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("fill_in_range")]
                        public new Types.FillInRange? FillInRange { get; set; }

                        /// <summary>
                        /// 获取或设置管理员范围信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("setting_manager_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("setting_manager_range")]
                        public new Types.ManagerRange? ManagerRange { get; set; }

                        /// <summary>
                        /// 获取或设置定时重复设置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timed_repeat_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("timed_repeat_info")]
                        public new Types.Repetition? Repetition { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置收集表标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_title")]
                [System.Text.Json.Serialization.JsonPropertyName("form_title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置收集表描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("form_desc")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置收集表表头背景图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_header")]
                [System.Text.Json.Serialization.JsonPropertyName("form_header")]
                public string? HeaderImageUrl { get; set; }

                /// <summary>
                /// 获取或设置收集表问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_question")]
                [System.Text.Json.Serialization.JsonPropertyName("form_question")]
                public Types.QuestionList? QuestionList { get; set; }

                /// <summary>
                /// 获取或设置收集表设置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("form_setting")]
                public Types.Settings? Settings { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oper")]
        [System.Text.Json.Serialization.JsonPropertyName("oper")]
        public int OperateMode { get; set; }

        /// <summary>
        /// 获取或设置收集表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("formid")]
        [System.Text.Json.Serialization.JsonPropertyName("formid")]
        public string FormId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收集表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_info")]
        [System.Text.Json.Serialization.JsonPropertyName("form_info")]
        public Types.Form Form { get; set; } = new Types.Form();
    }
}
