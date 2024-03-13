namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/getapprovaldetail 接口的响应。</para>
    /// </summary>
    public class CgibinOAGetApprovalDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Approval
            {
                public static class Types
                {
                    public class Applicant
                    {
                        /// <summary>
                        /// 获取或设置申请人成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置提单部门 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyid")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long DepartmentId { get; set; }
                    }

                    public class Notifier
                    {
                        /// <summary>
                        /// 获取或设置抄送人成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;
                    }

                    public class Record
                    {
                        public static class Types
                        {
                            public class RecordDetail
                            {
                                public static class Types
                                {
                                    public class Approver
                                    {
                                        /// <summary>
                                        /// 获取或设置审批人成员账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("userid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                        public string UserId { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置审批人信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("approver")]
                                [System.Text.Json.Serialization.JsonPropertyName("approver")]
                                public Types.Approver Approver { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分支审批状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sp_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("sp_status")]
                                public int ApproveStatus { get; set; }

                                /// <summary>
                                /// 获取或设置分支审批时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sptime")]
                                [System.Text.Json.Serialization.JsonPropertyName("sptime")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                                public long? ApproveTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("speech")]
                                [System.Text.Json.Serialization.JsonPropertyName("speech")]
                                public string? Speech { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见附件 MediaId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("media_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                                public string[]? SpeechMediaIdList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置节点审批状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sp_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("sp_status")]
                        public int ApproveStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审批方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("approverattr")]
                        [System.Text.Json.Serialization.JsonPropertyName("approverattr")]
                        public int ApproveType { get; set; }

                        /// <summary>
                        /// 获取或设置审批流程详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("details")]
                        [System.Text.Json.Serialization.JsonPropertyName("details")]
                        public Types.RecordDetail[] DetailList { get; set; } = default!;
                    }

                    public class MultiLangText : CgibinOAGetTemplateDetailResponse.Types.MultiLangText
                    {
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
                                        /// 获取或设置 TextSettings 控件文本值。
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
                                        public ContactControlValueAsUser[]? ContactMembers { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Contact 控件部门值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("departments")]
                                        [System.Text.Json.Serialization.JsonPropertyName("departments")]
                                        public ContactControlValueAsDepartment[]? ContactDepartments { get; set; }

                                        /// <summary>
                                        /// 获取或设置 File 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("files")]
                                        [System.Text.Json.Serialization.JsonPropertyName("files")]
                                        public FileControlValue[]? Files { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Table 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("children")]
                                        [System.Text.Json.Serialization.JsonPropertyName("children")]
                                        public TableControlValue[]? TableChildren { get; set; }

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
                                        public RelatedApprovalControlValue[]? RelatedApprovals { get; set; }

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

                                        /// <summary>
                                        /// 获取或设置 PunchCorrection 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("punch_correction")]
                                        [System.Text.Json.Serialization.JsonPropertyName("punch_correction")]
                                        public CheckinControlValue? Checkin { get; set; }
                                    }

                                    public class DateControlValue
                                    {
                                        public static class Types
                                        {
                                            public class Timezone
                                            {
                                                /// <summary>
                                                /// 获取或设置时区偏移量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("zone_offset")]
                                                [System.Text.Json.Serialization.JsonPropertyName("zone_offset")]
                                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                                public int Offset { get; set; }

                                                /// <summary>
                                                /// 获取或设置时区描述。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("zone_desc")]
                                                [System.Text.Json.Serialization.JsonPropertyName("zone_desc")]
                                                public string Description { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置时间展示类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                        public string Type { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("s_timestamp")]
                                        [System.Text.Json.Serialization.JsonPropertyName("s_timestamp")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                                        public long? Timestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置时区信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("timezone_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("timezone_info")]
                                        public Types.Timezone? Timezone { get; set; }
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
                                                public string Key { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置选项值。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                                public MultiLangText[] Value { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置选择方式。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                        public string Type { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置选项列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("options")]
                                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                                        public Types.Option[] OptionList { get; set; } = default!;
                                    }

                                    public class ContactControlValueAsUser
                                    {
                                        /// <summary>
                                        /// 获取或设置成员账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("userid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                        public string UserId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置成员名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string? Name { get; set; }
                                    }

                                    public class ContactControlValueAsDepartment
                                    {
                                        /// <summary>
                                        /// 获取或设置部门 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("openapi_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("openapi_id")]
                                        public long DepartmentId { get; set; }

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
                                        public string FileId { get; set; } = default!;
                                    }

                                    public class TableControlValue
                                    {
                                        public static class Types
                                        {
                                            public class TableDetail : ApplyContent
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置子明细列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("list")]
                                        public Types.TableDetail[] TableDetailList { get; set; } = default!;
                                    }

                                    public class AttendanceControlValue
                                    {
                                        public static class Types
                                        {
                                            public class DateRange : DateRangeControlValue
                                            {
                                            }

                                            public class Slice
                                            {
                                                public static class Types
                                                {
                                                    public class DayItem
                                                    {
                                                        /// <summary>
                                                        /// 获取或设置当天零点时间戳。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("daytime")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("daytime")]
                                                        public long DayTimestamp { get; set; }

                                                        /// <summary>
                                                        /// 获取或设置时长（单位：秒）。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("duration")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                                                        public int Duration { get; set; }
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置时长计算来源类型。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("state")]
                                                [System.Text.Json.Serialization.JsonPropertyName("state")]
                                                public int State { get; set; }

                                                /// <summary>
                                                /// 获取或设置每一天的分片时长列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("day_items")]
                                                [System.Text.Json.Serialization.JsonPropertyName("day_items")]
                                                public Types.DayItem[] DayItems { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置总时长（单位：秒）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("duration")]
                                                [System.Text.Json.Serialization.JsonPropertyName("duration")]
                                                public int TotalDuration { get; set; }
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
                                        public Types.DateRange DateRange { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置时长按天分片信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("slice_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("slice_info")]
                                        public Types.Slice? Slice { get; set; }
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
                                        public Types.Selector Selector { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置假勤内容填写信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("attendance")]
                                        [System.Text.Json.Serialization.JsonPropertyName("attendance")]
                                        public Types.Attendance Attendance { get; set; } = default!;
                                    }

                                    public class LocationControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置经度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("longitude")]
                                        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                                        public decimal Longitude { get; set; }

                                        /// <summary>
                                        /// 获取或设置纬度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("latitude")]
                                        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                                        public decimal Latitude { get; set; }

                                        /// <summary>
                                        /// 获取或设置地点标题。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("title")]
                                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                                        public string Title { get; set; } = default!;

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
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                                        public long? Timestamp { get; set; }
                                    }

                                    public class RelatedApprovalControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置模板名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("template_names")]
                                        [System.Text.Json.Serialization.JsonPropertyName("template_names")]
                                        public MultiLangText[] TemplateName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批单号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sp_no")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sp_no")]
                                        public string ApprovalNumber { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批单名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批单状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sp_status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sp_status")]
                                        public int Status { get; set; }

                                        /// <summary>
                                        /// 获取或设置提单时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("create_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                        public long CreateTimestamp { get; set; }
                                    }

                                    public class FormulaControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置公式的值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public string Value { get; set; } = default!;
                                    }

                                    public class DateRangeControlValue
                                    {
                                        public static class Types
                                        {
                                            public class Timezone : DateControlValue.Types.Timezone
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置时间展示类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                        public string Type { get; set; } = default!;

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

                                        /// <summary>
                                        /// 获取或设置时区信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("timezone_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("timezone_info")]
                                        public Types.Timezone? Timezone { get; set; }
                                    }

                                    public class CheckinControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置异常状态说明。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("state")]
                                        [System.Text.Json.Serialization.JsonPropertyName("state")]
                                        public string State { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置版本标识。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("version")]
                                        [System.Text.Json.Serialization.JsonPropertyName("version")]
                                        public int? Version { get; set; }

                                        /// <summary>
                                        /// 获取或设置补卡时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                                        public long? Timestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置补卡日期时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("daymonthyear")]
                                        [System.Text.Json.Serialization.JsonPropertyName("daymonthyear")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                                        public long? DateTimestamp { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置控件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("control")]
                                [System.Text.Json.Serialization.JsonPropertyName("control")]
                                public string Control { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置控件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string ControlId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置控件名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public MultiLangText[] Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public Types.Value Value { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置审批申请内容列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contents")]
                        [System.Text.Json.Serialization.JsonPropertyName("contents")]
                        public Types.ApplyContent[] ApplyContentList { get; set; } = default!;
                    }

                    public class Comment
                    {
                        public static class Types
                        {
                            public class CommentUser
                            {
                                /// <summary>
                                /// 获取或设置评论人成员账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userid")]
                                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                public string UserId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentid")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentid")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentUserInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentUserInfo")]
                        public Types.CommentUser CommentUser { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentcontent")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentcontent")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容附件 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string[] MediaIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commenttime")]
                        [System.Text.Json.Serialization.JsonPropertyName("commenttime")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审批单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_no")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_no")]
                public string ApprovalNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_status")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审批模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyer")]
                [System.Text.Json.Serialization.JsonPropertyName("applyer")]
                public Types.Applicant Applicant { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置抄送人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notifyer")]
                [System.Text.Json.Serialization.JsonPropertyName("notifyer")]
                public Types.Notifier[]? NotifyerList { get; set; }

                /// <summary>
                /// 获取或设置审批申请数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_data")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_data")]
                public Types.ApplyData ApplyData { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批流程列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_record")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_record")]
                public Types.Record[] RecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comments")]
                [System.Text.Json.Serialization.JsonPropertyName("comments")]
                public Types.Comment[] CommentList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置审批单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Approval Approval { get; set; } = default!;
    }
}
