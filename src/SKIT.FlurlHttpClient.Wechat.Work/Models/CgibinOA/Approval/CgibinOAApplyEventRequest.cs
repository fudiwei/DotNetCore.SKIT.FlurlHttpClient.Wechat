using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/applyevent 接口的请求。</para>
    /// </summary>
    public class CgibinOAApplyEventRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Approver
            {
                /// <summary>
                /// 获取或设置审批方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr")]
                [System.Text.Json.Serialization.JsonPropertyName("attr")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置审批人成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public IList<string> UserIdList { get; set; } = new List<string>();
            }

            public class MultiLangText
            {
                /// <summary>
                /// 获取或设置语言类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lang")]
                [System.Text.Json.Serialization.JsonPropertyName("lang")]
                public string Language { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = string.Empty;
            }

            public class ApplyData
            {
                public static class Types
                {
                    public class ApplyContent
                    {
                        public static class Types
                        {
                            public class Value
                            {
                                /// <summary>
                                /// 获取或设置 Text 控件文本值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string? Text { get; set; }

                                /// <summary>
                                /// 获取或设置 Number 控件数值的字符串形式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_number")]
                                public string? Number { get; set; }

                                /// <summary>
                                /// 获取或设置 Money 控件金额的字符串形式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_money")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_money")]
                                public string? Money { get; set; }

                                /// <summary>
                                /// 获取或设置 Date 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date")]
                                [System.Text.Json.Serialization.JsonPropertyName("date")]
                                public DateControlValue? Date { get; set; }

                                /// <summary>
                                /// 获取或设置 Selector 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("selector")]
                                [System.Text.Json.Serialization.JsonPropertyName("selector")]
                                public SelectorControlValue? Selector { get; set; }

                                /// <summary>
                                /// 获取或设置 Contact 控件成员值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("members")]
                                [System.Text.Json.Serialization.JsonPropertyName("members")]
                                public IList<ContactControlValueForUser>? ContactMembers { get; set; }

                                /// <summary>
                                /// 获取或设置 Contact 控件部门值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("departments")]
                                [System.Text.Json.Serialization.JsonPropertyName("departments")]
                                public IList<ContactControlValueForDepartment>? ContactDepartments { get; set; }

                                /// <summary>
                                /// 获取或设置 File 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("files")]
                                [System.Text.Json.Serialization.JsonPropertyName("files")]
                                public IList<FileControlValue>? Files { get; set; }

                                /// <summary>
                                /// 获取或设置 Table 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("children")]
                                [System.Text.Json.Serialization.JsonPropertyName("children")]
                                public IList<TableControlValue>? TableChildren { get; set; }

                                /// <summary>
                                /// 获取或设置 Attendance 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attendance")]
                                [System.Text.Json.Serialization.JsonPropertyName("attendance")]
                                public AttendanceControlValue? Attendance { get; set; }

                                /// <summary>
                                /// 获取或设置 Vacation 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("vacation")]
                                [System.Text.Json.Serialization.JsonPropertyName("vacation")]
                                public VacationControlValue? Vacation { get; set; }

                                /// <summary>
                                /// 获取或设置 Location 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("location")]
                                [System.Text.Json.Serialization.JsonPropertyName("location")]
                                public LocationControlValue? Location { get; set; }

                                /// <summary>
                                /// 获取或设置 RelatedApproval 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("related_approval")]
                                [System.Text.Json.Serialization.JsonPropertyName("related_approval")]
                                public IList<RelatedApprovalControlValue>? RelatedApprovals { get; set; }

                                /// <summary>
                                /// 获取或设置 Formula 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("formula")]
                                [System.Text.Json.Serialization.JsonPropertyName("formula")]
                                public FormulaControlValue? Formula { get; set; }

                                /// <summary>
                                /// 获取或设置 DateRange 控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date_range")]
                                [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                public DateRangeControlValue? DateRange { get; set; }
                            }

                            public class DateControlValue
                            {
                                /// <summary>
                                /// 获取或设置时间展示类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("s_timestamp")]
                                [System.Text.Json.Serialization.JsonPropertyName("s_timestamp")]
                                public long Timestamp { get; set; }
                            }

                            public class SelectorControlValue
                            {
                                public static class Types
                                {
                                    public class Option
                                    {
                                        /// <summary>
                                        /// 获取或设置选项 Key。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("key")]
                                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                                        public string Key { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置选项值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public IList<MultiLangText>? Value { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置选择方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置选项列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("options")]
                                [System.Text.Json.Serialization.JsonPropertyName("options")]
                                public IList<Types.Option> OptionList { get; set; } = new List<Types.Option>();
                            }

                            public class ContactControlValueForUser
                            {
                                /// <summary>
                                /// 获取或设置成员账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userid")]
                                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                public string UserId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置成员名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? Name { get; set; }
                            }

                            public class ContactControlValueForDepartment
                            {
                                /// <summary>
                                /// 获取或设置部门 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("openapi_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("openapi_id")]
                                public int DepartmentId { get; set; }

                                /// <summary>
                                /// 获取或设置成员名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? Name { get; set; }
                            }

                            public class FileControlValue
                            {
                                /// <summary>
                                /// 获取或设置文件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("file_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("file_id")]
                                public string FileId { get; set; } = string.Empty;
                            }

                            public class TableControlValue
                            {
                                public static class Types
                                {
                                    public class TableDetail : ApplyContent
                                    {
                                        /// <summary>
                                        /// 获取或设置控件名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("title")]
                                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                                        public IList<MultiLangText> Title { get; set; } = new List<MultiLangText>();
                                    }
                                }

                                /// <summary>
                                /// 获取或设置子明细列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list")]
                                [System.Text.Json.Serialization.JsonPropertyName("list")]
                                public IList<Types.TableDetail> TableDetailList { get; set; } = new List<Types.TableDetail>();
                            }

                            public class AttendanceControlValue
                            {
                                public static class Types
                                {
                                    public class DateRange : DateRangeControlValue
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置假勤类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置时间选择范围。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date_range")]
                                [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                public Types.DateRange DateRange { get; set; } = new Types.DateRange();
                            }

                            public class VacationControlValue
                            {
                                public static class Types
                                {
                                    public class Selector : SelectorControlValue
                                    {
                                    }

                                    public class Attendance : AttendanceControlValue
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置请假类型选择信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("selector")]
                                [System.Text.Json.Serialization.JsonPropertyName("selector")]
                                public Types.Selector Selector { get; set; } = new Types.Selector();

                                /// <summary>
                                /// 获取或设置假勤内容填写信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attendance")]
                                [System.Text.Json.Serialization.JsonPropertyName("attendance")]
                                public Types.Attendance Attendance { get; set; } = new Types.Attendance();
                            }

                            public class LocationControlValue
                            {
                                /// <summary>
                                /// 获取或设置经度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("longitude")]
                                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                                public double Longitude { get; set; }

                                /// <summary>
                                /// 获取或设置纬度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("latitude")]
                                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                                public double Latitude { get; set; }

                                /// <summary>
                                /// 获取或设置地点标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置地点详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address")]
                                [System.Text.Json.Serialization.JsonPropertyName("address")]
                                public string? Address { get; set; }

                                /// <summary>
                                /// 获取或设置选择地点的时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public long Timestamp { get; set; }
                            }

                            public class RelatedApprovalControlValue
                            {
                                /// <summary>
                                /// 获取或设置审批单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sp_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("sp_no")]
                                public string ApprovalNumber { get; set; } = string.Empty;
                            }

                            public class FormulaControlValue
                            {
                                /// <summary>
                                /// 获取或设置公式的值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public string Value { get; set; } = string.Empty;
                            }

                            public class DateRangeControlValue
                            {
                                /// <summary>
                                /// 获取或设置时间刻度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_begin")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_begin")]
                                public long BeginTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_end")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_end")]
                                public long EndTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置时长范围（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("new_duration")]
                                [System.Text.Json.Serialization.JsonPropertyName("new_duration")]
                                public int Duration { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置控件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("control")]
                        [System.Text.Json.Serialization.JsonPropertyName("control")]
                        public string Control { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置控件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string ControlId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置控件值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public Types.Value Value { get; set; } = new Types.Value();
                    }
                }

                /// <summary>
                /// 获取或设置审批申请内容列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contents")]
                [System.Text.Json.Serialization.JsonPropertyName("contents")]
                public IList<Types.ApplyContent> ApplyContentList { get; set; } = new List<Types.ApplyContent>();
            }

            public class SummaryData
            {
                /// <summary>
                /// 获取或设置摘要行信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("summary_info")]
                [System.Text.Json.Serialization.JsonPropertyName("summary_info")]
                public IList<MultiLangText> Summary { get; set; } = new List<MultiLangText>();
            }
        }

        /// <summary>
        /// 获取或设置申请人成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("creator_userid")]
        public string ApplicantUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提单部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("choose_department")]
        [System.Text.Json.Serialization.JsonPropertyName("choose_department")]
        public int? ApplicantDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置审批模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否启用审批人模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_template_approver")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("use_template_approver")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool UseTemplateApprover { get; set; }

        /// <summary>
        /// 获取或设置审批人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approver")]
        [System.Text.Json.Serialization.JsonPropertyName("approver")]
        public IList<Types.Approver> ApproverList { get; set; } = new List<Types.Approver>();

        /// <summary>
        /// 获取或设置抄送方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_type")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_type")]
        public int? NotifyType { get; set; }

        /// <summary>
        /// 获取或设置抄送人成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notifyer")]
        [System.Text.Json.Serialization.JsonPropertyName("notifyer")]
        public IList<string>? NotifierUserIdList { get; set; }

        /// <summary>
        /// 获取或设置审批申请数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_data")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_data")]
        public Types.ApplyData ApplyData { get; set; } = new Types.ApplyData();

        /// <summary>
        /// 获取或设置摘要列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summary_list")]
        [System.Text.Json.Serialization.JsonPropertyName("summary_list")]
        public IList<Types.SummaryData> SummaryList { get; set; } = new List<Types.SummaryData>();
    }
}
