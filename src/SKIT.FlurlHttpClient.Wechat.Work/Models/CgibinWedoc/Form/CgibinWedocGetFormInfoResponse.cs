namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_form_info 接口的响应。</para>
    /// </summary>
    public class CgibinWedocGetFormInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Form
            {
                public static class Types
                {
                    public class QuestionList
                    {
                        /// <summary>
                        /// 获取或设置问题列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("items")]
                        [System.Text.Json.Serialization.JsonPropertyName("items")]
                        public QuestionItem[] Items { get; set; } = default!;
                    }

                    public class QuestionItem
                    {
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置选项键
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("key")]
                                [System.Text.Json.Serialization.JsonPropertyName("key")]
                                public int Key { get; set; }

                                /// <summary>
                                /// 获取或设置选项值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public string Value { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置选项状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }
                            }

                            public class ExtendedSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置问题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_id")]
                        public int QuestionId { get; set; }

                        /// <summary>
                        /// 获取或设置问题序号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pos")]
                        [System.Text.Json.Serialization.JsonPropertyName("pos")]
                        public int Sequence { get; set; }

                        /// <summary>
                        /// 获取或设置问题描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置回答类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_type")]
                        public int ReplyType { get; set; }

                        /// <summary>
                        /// 获取或设置是否必答。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("must_reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("must_reply")]
                        public bool IsMustReply { get; set; }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_item")]
                        public Types.Option[]? OptionList { get; set; }

                        /// <summary>
                        /// 获取或设置问题备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("note")]
                        [System.Text.Json.Serialization.JsonPropertyName("note")]
                        public string? Note { get; set; }

                        /// <summary>
                        /// 获取或设置编辑提示。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("placeholder")]
                        [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
                        public string? Placeholder { get; set; }

                        /// <summary>
                        /// 获取或设置问题的额外设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_extend_setting")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_extend_setting")]
                        public Types.ExtendedSettings? ExtendedSettings { get; set; }
                    }

                    public class Settings
                    {
                        public static class Types
                        {
                            public class FillInRange
                            {
                                /// <summary>
                                /// 获取或设置 UserId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userids")]
                                [System.Text.Json.Serialization.JsonPropertyName("userids")]
                                public string[]? UserIdList { get; set; }

                                /// <summary>
                                /// 获取或设置部门 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("departmentids")]
                                [System.Text.Json.Serialization.JsonPropertyName("departmentids")]
                                public long[]? DepartmentIdList { get; set; }
                            }

                            public class ManagerRange
                            {
                                /// <summary>
                                /// 获取或设置 UserId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userids")]
                                [System.Text.Json.Serialization.JsonPropertyName("userids")]
                                public string[] UserIdList { get; set; } = default!;
                            }

                            public class Repetition
                            {
                                /// <summary>
                                /// 获取或设置是否开启定时重复。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enable")]
                                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                                public bool IsEnabled { get; set; }

                                /// <summary>
                                /// 获取或设置提醒时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("remind_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("remind_time")]
                                public long? RemindTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置重复类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("repeat_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("repeat_type")]
                                public int? RepeatType { get; set; }

                                /// <summary>
                                /// 获取或设置每周周几重复。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("week_flag")]
                                [System.Text.Json.Serialization.JsonPropertyName("week_flag")]
                                public int? RepeatDayOfWeek { get; set; }

                                /// <summary>
                                /// 获取或设置每月第几天重复。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("day_of_month")]
                                [System.Text.Json.Serialization.JsonPropertyName("day_of_month")]
                                public int? RepeatDayOfMonth { get; set; }

                                /// <summary>
                                /// 获取或设置是否跳过节假日。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("skip_holiday")]
                                [System.Text.Json.Serialization.JsonPropertyName("skip_holiday")]
                                public bool? IsSkipHoliday { get; set; }

                                /// <summary>
                                /// 获取或设置补填类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fork_finish_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("fork_finish_type")]
                                public int? ForkFinishType { get; set; }

                                /// <summary>
                                /// 获取或设置规则创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rule_ctime")]
                                [System.Text.Json.Serialization.JsonPropertyName("rule_ctime")]
                                public long? RuleCreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置规则修改时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rule_mtime")]
                                [System.Text.Json.Serialization.JsonPropertyName("rule_mtime")]
                                public long? RuleModifyTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置填写权限类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fill_out_auth")]
                        [System.Text.Json.Serialization.JsonPropertyName("fill_out_auth")]
                        public int FillOutAuthType { get; set; }

                        /// <summary>
                        /// 获取或设置填写范围信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fill_in_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("fill_in_range")]
                        public Types.FillInRange? FillInRange { get; set; }

                        /// <summary>
                        /// 获取或设置管理员范围信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("setting_manager_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("setting_manager_range")]
                        public Types.ManagerRange? ManagerRange { get; set; }

                        /// <summary>
                        /// 获取或设置定时重复设置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timed_repeat_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("timed_repeat_info")]
                        public Types.Repetition? Repetition { get; set; }

                        /// <summary>
                        /// 获取或设置最多填写数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_fill_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_fill_cnt")]
                        public int MaxFillCount { get; set; }

                        /// <summary>
                        /// 获取或设置定时关闭时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timed_finish")]
                        [System.Text.Json.Serialization.JsonPropertyName("timed_finish")]
                        public long? FinishTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持匿名填写。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_anonymous")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_anonymous")]
                        public bool EnableAnonymous { get; set; }

                        /// <summary>
                        /// 获取或设置是否有回复时提醒。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_notify_submit")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_notify_submit")]
                        public bool EnableNotifySubmit { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置收集表 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("formid")]
                [System.Text.Json.Serialization.JsonPropertyName("formid")]
                public string FormId { get; set; } = default!;

                /// <summary>
                /// 获取或设置收集表标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_title")]
                [System.Text.Json.Serialization.JsonPropertyName("form_title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置收集表描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("form_desc")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置收集表表头背景图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_header")]
                [System.Text.Json.Serialization.JsonPropertyName("form_header")]
                public string HeaderImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置收集表问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_question")]
                [System.Text.Json.Serialization.JsonPropertyName("form_question")]
                public Types.QuestionList QuestionList { get; set; } = default!;

                /// <summary>
                /// 获取或设置收集表设置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("form_setting")]
                public Types.Settings Settings { get; set; } = default!;

                /// <summary>
                /// 获取或设置收集表周期 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeated_id")]
                [System.Text.Json.Serialization.JsonPropertyName("repeated_id")]
                public string[]? RepeatedId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置收集表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_info")]
        [System.Text.Json.Serialization.JsonPropertyName("form_info")]
        public Types.Form Form { get; set; } = default!;
    }
}
