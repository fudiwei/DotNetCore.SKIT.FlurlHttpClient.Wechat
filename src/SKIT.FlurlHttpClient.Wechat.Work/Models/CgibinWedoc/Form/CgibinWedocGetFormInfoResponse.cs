namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_form_info 接口的响应。</para>
    /// </summary>
    public class CgibinWedocGetFormInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Form : CgibinWedocCreateFormRequest.Types.__zz__Form
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
                        public List<QuestionItem>? Items { get; set; }
                    }

                    public class QuestionItem : CgibinWedocCreateFormRequest.Types.Form.Types.__zz__QuestionItem
                    {
                        public static class Types
                        {
                            public class Option : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.Option
                            {
                            }

                            public class ExtendedSettings
                            {
                                public static class Types
                                {
                                    public class TextSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.TextSettings
                                    {
                                    }

                                    public class RadioSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.RadioSettings
                                    {
                                    }

                                    public class CheckboxSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.CheckboxSettings
                                    {
                                    }

                                    public class LocationSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.LocationSettings
                                    {
                                    }

                                    public class ImageSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.__zz__ImageSettings
                                    {
                                        public static class Types
                                        {
                                            public class UploadLimitation : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.ImageSettings.Types.UploadLimitation
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置上传限制信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("upload_image_limit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("upload_image_limit")]
                                        public Types.UploadLimitation? UploadLimitation { get; set; }
                                    }

                                    public class FileSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.__zz__FileSettings
                                    {
                                        public static class Types
                                        {
                                            public class UploadLimitation : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.FileSettings.Types.UploadLimitation
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置上传限制信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("upload_image_limit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("upload_image_limit")]
                                        public Types.UploadLimitation? UploadLimitation { get; set; }
                                    }

                                    public class DateSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.DateSettings
                                    {
                                    }

                                    public class TimeSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.TimeSettings
                                    {
                                    }

                                    public class DurationSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.DurationSettings
                                    {
                                    }

                                    public class TemperatureSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.TemperatureSettings
                                    {
                                    }

                                    public class DepartmentSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.DepartmentSettings
                                    {
                                    }

                                    public class MemberSettings : CgibinWedocCreateFormRequest.Types.Form.Types.QuestionItem.Types.ExtendedSettings.Types.MemberSettings
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置文本题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("text_setting")]
                                public Types.TextSettings? TextSettings { get; set; }

                                /// <summary>
                                /// 获取或设置单选题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("radio_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("radio_setting")]
                                public Types.RadioSettings? RadioSettings { get; set; }

                                /// <summary>
                                /// 获取或设置多选题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("checkbox_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("checkbox_setting")]
                                public Types.CheckboxSettings? CheckboxSettings { get; set; }

                                /// <summary>
                                /// 获取或设置位置题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("location_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("location_setting")]
                                public Types.LocationSettings? LocationSettings { get; set; }

                                /// <summary>
                                /// 获取或设置图片题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_setting")]
                                public Types.ImageSettings? ImageSettings { get; set; }

                                /// <summary>
                                /// 获取或设置文件题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("file_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("file_setting")]
                                public Types.FileSettings? FileSettings { get; set; }

                                /// <summary>
                                /// 获取或设置日期题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("date_setting")]
                                public Types.DateSettings? DateSettings { get; set; }

                                /// <summary>
                                /// 获取或设置时间题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_setting")]
                                public Types.TimeSettings? TimeSettings { get; set; }

                                /// <summary>
                                /// 获取或设置时长题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("duration_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("duration_setting")]
                                public Types.DurationSettings? DurationSettings { get; set; }

                                /// <summary>
                                /// 获取或设置体温题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("temperature_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("temperature_setting")]
                                public Types.TemperatureSettings? TemperatureSettings { get; set; }

                                /// <summary>
                                /// 获取或设置部门题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("department_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("department_setting")]
                                public Types.DepartmentSettings? DepartmentSettings { get; set; }

                                /// <summary>
                                /// 获取或设置成员题的题目设置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("member_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("member_setting")]
                                public Types.MemberSettings? MemberSettings { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_item")]
                        public List<Types.Option>? OptionList { get; set; }

                        /// <summary>
                        /// 获取或设置问题的额外设置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_extend_setting")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_extend_setting")]
                        public Types.ExtendedSettings? ExtendedSettings { get; set; }
                    }

                    public class Settings : CgibinWedocCreateFormRequest.Types.Form.Types.__zz__Settings
                    {
                        public static class Types
                        {
                            public class FillInRange : CgibinWedocCreateFormRequest.Types.Form.Types.Settings.Types.FillInRange
                            {
                            }

                            public class ManagerRange : CgibinWedocCreateFormRequest.Types.Form.Types.Settings.Types.ManagerRange
                            {
                            }

                            public class Repetition : CgibinWedocCreateFormRequest.Types.Form.Types.Settings.Types.Repetition
                            {
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
                    }
                }

                /// <summary>
                /// 获取或设置收集表 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("formid")]
                [System.Text.Json.Serialization.JsonPropertyName("formid")]
                public string? FormId { get; set; }

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

                /// <summary>
                /// 获取或设置收集表周期 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeated_id")]
                [System.Text.Json.Serialization.JsonPropertyName("repeated_id")]
                public List<string>? RepeatedId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置收集表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_info")]
        [System.Text.Json.Serialization.JsonPropertyName("form_info")]
        public Types.Form? Form { get; set; }
    }
}
