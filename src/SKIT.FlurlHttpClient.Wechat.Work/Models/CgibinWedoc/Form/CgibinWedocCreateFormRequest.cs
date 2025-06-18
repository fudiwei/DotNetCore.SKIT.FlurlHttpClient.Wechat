using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/create_form 接口的请求。</para>
    /// </summary>
    public class CgibinWedocCreateFormRequest : WechatWorkRequest
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
                        public IList<QuestionItem> Items { get; set; } = new List<QuestionItem>();
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
                                public string Value { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选项状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }
                            }

                            public class ExtendedSettings
                            {
                                public static class Types
                                {
                                    public class TextSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置校验类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("validation_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("validation_type")]
                                        public int? ValidationType { get; set; }

                                        /// <summary>
                                        /// 获取或设置校验详情类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("validation_detail")]
                                        [System.Text.Json.Serialization.JsonPropertyName("validation_detail")]
                                        public int? ValidationDetailType { get; set; }

                                        /// <summary>
                                        /// 获取或设置字符长度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("char_len")]
                                        [System.Text.Json.Serialization.JsonPropertyName("char_len")]
                                        public int? CharacterLength { get; set; }

                                        /// <summary>
                                        /// 获取或设置数字的区间左端。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("number_min")]
                                        [System.Text.Json.Serialization.JsonPropertyName("number_min")]
                                        public decimal? NumberMinimum { get; set; }

                                        /// <summary>
                                        /// 获取或设置数字的区间右端。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("number_max")]
                                        [System.Text.Json.Serialization.JsonPropertyName("number_max")]
                                        public decimal? NumberMaximum { get; set; }
                                    }

                                    public class RadioSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置是否增加“其他”选项。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("add_other_option")]
                                        [System.Text.Json.Serialization.JsonPropertyName("add_other_option")]
                                        public bool? RequireAddOtherOption { get; set; }
                                    }

                                    public class CheckboxSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置是否增加“其他”选项。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("add_other_option")]
                                        [System.Text.Json.Serialization.JsonPropertyName("add_other_option")]
                                        public bool? RequireAddOtherOption { get; set; }

                                        /// <summary>
                                        /// 获取或设置多选类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                        public int? Type { get; set; }

                                        /// <summary>
                                        /// 获取或设置多选题可勾选的数量的限制。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("number")]
                                        [System.Text.Json.Serialization.JsonPropertyName("number")]
                                        public int? Count { get; set; }
                                    }

                                    public class LocationSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置位置类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("location_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("location_type")]
                                        public int? LocationType { get; set; }

                                        /// <summary>
                                        /// 获取或设置允许定位范围类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("distance_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("distance_type")]
                                        public int? DistanceType { get; set; }
                                    }

                                    public class ImageSettings
                                    {
                                        public static class Types
                                        {
                                            public class UploadLimitation
                                            {
                                                /// <summary>
                                                /// 获取或设置数量限制类型。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("count_limit_type")]
                                                [System.Text.Json.Serialization.JsonPropertyName("count_limit_type")]
                                                public int? CountLimitType { get; set; }

                                                /// <summary>
                                                /// 获取或设置数量限制。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("count")]
                                                [System.Text.Json.Serialization.JsonPropertyName("count")]
                                                public int? Count { get; set; }

                                                /// <summary>
                                                /// 获取或设置单个文件大小限制（单位：字节）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("max_size")]
                                                [System.Text.Json.Serialization.JsonPropertyName("max_size")]
                                                public int? MaxSize { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置是否仅限手机拍照。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("camera_only")]
                                        [System.Text.Json.Serialization.JsonPropertyName("camera_only")]
                                        public bool? IsCameraOnly { get; set; }

                                        /// <summary>
                                        /// 获取或设置上传限制信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("upload_image_limit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("upload_image_limit")]
                                        public Types.UploadLimitation? UploadLimitation { get; set; }
                                    }

                                    public class FileSettings
                                    {
                                        public static class Types
                                        {
                                            public class UploadLimitation : ImageSettings.Types.UploadLimitation
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置是否仅限手机拍照。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("camera_only")]
                                        [System.Text.Json.Serialization.JsonPropertyName("camera_only")]
                                        public bool? IsCameraOnly { get; set; }

                                        /// <summary>
                                        /// 获取或设置上传限制信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("upload_image_limit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("upload_image_limit")]
                                        public Types.UploadLimitation? UploadLimitation { get; set; }
                                    }

                                    public class DateSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置日期格式类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("date_format_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("date_format_type")]
                                        public int? DateFormatType { get; set; }
                                    }

                                    public class TimeSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置时间格式类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("time_format_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("time_format_type")]
                                        public int? TimeFormatType { get; set; }
                                    }

                                    public class DurationSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置时间刻度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("time_scale")]
                                        [System.Text.Json.Serialization.JsonPropertyName("time_scale")]
                                        public int? TimeScale { get; set; }

                                        /// <summary>
                                        /// 获取或设置日期类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("date_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("date_type")]
                                        public int? DateType { get; set; }

                                        /// <summary>
                                        /// 获取或设置单位换算。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("day_range")]
                                        [System.Text.Json.Serialization.JsonPropertyName("day_range")]
                                        public int? DayRange { get; set; }
                                    }

                                    public class TemperatureSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置温度单位类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("unit_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("unit_type")]
                                        public int? UnitType { get; set; }
                                    }

                                    public class DepartmentSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置是否允许多选。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("allow_multiple_selection")]
                                        [System.Text.Json.Serialization.JsonPropertyName("allow_multiple_selection")]
                                        public bool? AllowMultipleSelection { get; set; }
                                    }

                                    public class MemberSettings
                                    {
                                        /// <summary>
                                        /// 获取或设置是否允许多选。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("allow_multiple_selection")]
                                        [System.Text.Json.Serialization.JsonPropertyName("allow_multiple_selection")]
                                        public bool? AllowMultipleSelection { get; set; }
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
                        public string Title { get; set; } = string.Empty;

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
                        public IList<Types.Option>? OptionList { get; set; }

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
                                public IList<string>? UserIdList { get; set; }

                                /// <summary>
                                /// 获取或设置部门 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("departmentids")]
                                [System.Text.Json.Serialization.JsonPropertyName("departmentids")]
                                public IList<long>? DepartmentIdList { get; set; }
                            }

                            public class ManagerRange
                            {
                                /// <summary>
                                /// 获取或设置 UserId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userids")]
                                [System.Text.Json.Serialization.JsonPropertyName("userids")]
                                public IList<string> UserIdList { get; set; } = new List<string>();
                            }

                            public class Repetition
                            {
                                /// <summary>
                                /// 获取或设置是否开启定时重复。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enable")]
                                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                                public bool? IsEnabled { get; set; }

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
                            }
                        }

                        /// <summary>
                        /// 获取或设置填写权限类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fill_out_auth")]
                        [System.Text.Json.Serialization.JsonPropertyName("fill_out_auth")]
                        public int? FillOutAuthType { get; set; }

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
                        public int? MaxFillCount { get; set; }

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
                        public bool? EnableAnonymous { get; set; }

                        /// <summary>
                        /// 获取或设置是否有回复时提醒。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_notify_submit")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_notify_submit")]
                        public bool? EnableNotifySubmit { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置收集表标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_title")]
                [System.Text.Json.Serialization.JsonPropertyName("form_title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收集表描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("form_desc")]
                public string? Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收集表表头背景图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_header")]
                [System.Text.Json.Serialization.JsonPropertyName("form_header")]
                public string? HeaderImageUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收集表问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_question")]
                [System.Text.Json.Serialization.JsonPropertyName("form_question")]
                public Types.QuestionList QuestionList { get; set; } = new Types.QuestionList();

                /// <summary>
                /// 获取或设置收集表设置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("form_setting")]
                public Types.Settings? Settings { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 获取或设置上级文件 ID 或空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fatherid")]
        [System.Text.Json.Serialization.JsonPropertyName("fatherid")]
        public string? ParentFileOrSpaceId { get; set; }

        /// <summary>
        /// 获取或设置收集表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_info")]
        [System.Text.Json.Serialization.JsonPropertyName("form_info")]
        public Types.Form Form { get; set; } = new Types.Form();
    }
}
