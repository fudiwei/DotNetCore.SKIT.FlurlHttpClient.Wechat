namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/get_record_detail 接口的响应。</para>
    /// </summary>
    public class CgibinOAJournalGetRecordDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Journal
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;
                    }

                    public class MultiLangText : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.MultiLangText
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
                                        public ContactControlValueForUser[]? ContactMembers { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Contact 控件部门值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("departments")]
                                        [System.Text.Json.Serialization.JsonPropertyName("departments")]
                                        public ContactControlValueForDepartment[]? ContactDepartments { get; set; }

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

                                        /// <summary>
                                        /// 获取或设置 SchoolContact 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("students")]
                                        [System.Text.Json.Serialization.JsonPropertyName("students")]
                                        public SchoolContactControlValue[]? Students { get; set; }

                                        /// <summary>
                                        /// 获取或设置 SchoolContact 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("classes")]
                                        [System.Text.Json.Serialization.JsonPropertyName("classes")]
                                        public SchoolContactControlValue[]? Classes { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Doc 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("docs")]
                                        [System.Text.Json.Serialization.JsonPropertyName("docs")]
                                        public DocumentControlValue[]? Documents { get; set; }

                                        /// <summary>
                                        /// 获取或设置 WedriveFile 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("wedrive_files")]
                                        [System.Text.Json.Serialization.JsonPropertyName("wedrive_files")]
                                        public WedriveFileControlValue[]? WedriveFiles { get; set; }
                                    }

                                    public class DateControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.DateControlValue
                                    {
                                    }

                                    public class SelectorControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.SelectorControlValue
                                    {
                                        public new static class Types
                                        {
                                            public class Option : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.SelectorControlValue.Types.Option
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置选项列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("options")]
                                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                                        public new Types.Option[] OptionList { get; set; } = default!;
                                    }

                                    public class ContactControlValueForUser : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.ContactControlValueForUser
                                    {
                                    }

                                    public class ContactControlValueForDepartment : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.ContactControlValueForDepartment
                                    {
                                    }

                                    public class FileControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.FileControlValue
                                    {
                                    }

                                    public class TableControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.TableControlValue
                                    {
                                        public new static class Types
                                        {
                                            public class TableDetail : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.TableControlValue.Types.TableDetail
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置子明细列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("list")]
                                        public new Types.TableDetail[] TableDetailList { get; set; } = default!;
                                    }

                                    public class AttendanceControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.AttendanceControlValue
                                    {
                                        public new static class Types
                                        {
                                            public class DateRange : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.AttendanceControlValue.Types.DateRange
                                            {
                                            }

                                            public class Slice : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.AttendanceControlValue.Types.Slice
                                            {
                                                public new static class Types
                                                {
                                                    public class DayItem : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.AttendanceControlValue.Types.Slice.Types.DayItem
                                                    {
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置每一天的分片时长列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("day_items")]
                                                [System.Text.Json.Serialization.JsonPropertyName("day_items")]
                                                public new Types.DayItem[] DayItems { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置时间选择范围。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("date_range")]
                                        [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                        public new Types.DateRange DateRange { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置时长按天分片信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("slice_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("slice_info")]
                                        public new Types.Slice? Slice { get; set; }
                                    }

                                    public class VacationControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.VacationControlValue
                                    {
                                        public new static class Types
                                        {
                                            public class Selector : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.VacationControlValue.Types.Selector
                                            {
                                            }

                                            public class Attendance : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.VacationControlValue.Types.Attendance
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置请假类型选择信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("selector")]
                                        [System.Text.Json.Serialization.JsonPropertyName("selector")]
                                        public new Types.Selector Selector { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置假勤内容填写信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("attendance")]
                                        [System.Text.Json.Serialization.JsonPropertyName("attendance")]
                                        public new Types.Attendance Attendance { get; set; } = default!;
                                    }

                                    public class LocationControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.LocationControlValue
                                    {
                                    }

                                    public class RelatedApprovalControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.RelatedApprovalControlValue
                                    {
                                    }

                                    public class FormulaControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.FormulaControlValue
                                    {
                                    }

                                    public class DateRangeControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.DateRangeControlValue
                                    {
                                    }

                                    public class CheckinControlValue : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData.Types.ApplyContent.Types.CheckinControlValue
                                    {
                                    }

                                    public class SchoolContactControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置学生名。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;
                                    }

                                    public class DocumentControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置文档 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("docid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("docid")]
                                        public string DocumentId { get; set; } = default!;
                                    }

                                    public class WedriveFileControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置微盘文件 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("fileid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
                                        public string FileId { get; set; } = default!;
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
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回复评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tocommentid")]
                        [System.Text.Json.Serialization.JsonPropertyName("tocommentid")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string? ToCommentId { get; set; }

                        /// <summary>
                        /// 获取或设置评论人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_userinfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_userinfo")]
                        public Types.CommentUser CommentUser { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置汇报 UUID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("journal_uuid")]
                [System.Text.Json.Serialization.JsonPropertyName("journal_uuid")]
                public string JournalId { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报表单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报表单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_name")]
                [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                public string TemplateName { get; set; } = default!;

                /// <summary>
                /// 获取或设置提交者信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("submitter")]
                [System.Text.Json.Serialization.JsonPropertyName("submitter")]
                public Types.User Submitter { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receivers")]
                [System.Text.Json.Serialization.JsonPropertyName("receivers")]
                public Types.User[] ReceiverList { get; set; } = default!;

                /// <summary>
                /// 获取或设置已读接收者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("readed_receivers")]
                [System.Text.Json.Serialization.JsonPropertyName("readed_receivers")]
                public Types.User[] ReadedReceiverList { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_data")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_data")]
                public Types.ApplyData ApplyData { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comments")]
                [System.Text.Json.Serialization.JsonPropertyName("comments")]
                public Types.Comment[] CommentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_time")]
                [System.Text.Json.Serialization.JsonPropertyName("report_time")]
                public long ReportTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置汇报信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Journal Journal { get; set; } = default!;
    }
}
