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
                        public string? UserId { get; set; }

                        /// <summary>
                        /// 获取或设置提单部门 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyid")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long DepartmentId { get; set; }
                    }

                    public class BatchApplicant
                    {
                        /// <summary>
                        /// 获取或设置申请人成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string? UserId { get; set; }
                    }

                    public class Notifier
                    {
                        /// <summary>
                        /// 获取或设置抄送人成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string? UserId { get; set; }
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
                                        public string? UserId { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置审批人信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("approver")]
                                [System.Text.Json.Serialization.JsonPropertyName("approver")]
                                public Types.Approver? Approver { get; set; }

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
                                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
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
                                public List<string>? AttachmentMediaIdList { get; set; }
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
                        public List<Types.RecordDetail>? DetailList { get; set; }
                    }

                    public class MultiLangText : CgibinOAApplyEventRequest.Types.MultiLangText
                    {
                    }

                    public class ApplyData
                    {
                        public static class Types
                        {
                            public class ApplyContent : CgibinOAApplyEventRequest.Types.ApplyData.Types.__zz__ApplyContent
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
                                        public List<ContactControlValueAsUser>? ContactMembers { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Contact 控件部门值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("departments")]
                                        [System.Text.Json.Serialization.JsonPropertyName("departments")]
                                        public List<ContactControlValueAsDepartment>? ContactDepartments { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Tips 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tips")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tips")]
                                        public List<TipsControlValue>? Tips { get; set; }

                                        /// <summary>
                                        /// 获取或设置 File 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("files")]
                                        [System.Text.Json.Serialization.JsonPropertyName("files")]
                                        public List<FileControlValue>? Files { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Table 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("children")]
                                        [System.Text.Json.Serialization.JsonPropertyName("children")]
                                        public List<TableControlValue>? TableChildren { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Vacation 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("vacation")]
                                        [System.Text.Json.Serialization.JsonPropertyName("vacation")]
                                        public VacationControlValue? Vacation { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Attendance 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("attendance")]
                                        [System.Text.Json.Serialization.JsonPropertyName("attendance")]
                                        public AttendanceControlValue? Attendance { get; set; }

                                        /// <summary>
                                        /// 获取或设置 PunchCorrection 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("punch_correction")]
                                        [System.Text.Json.Serialization.JsonPropertyName("punch_correction")]
                                        public CheckinControlValue? Checkin { get; set; }

                                        /// <summary>
                                        /// 获取或设置 DateRange 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("date_range")]
                                        [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                        public DateRangeControlValue? DateRange { get; set; }

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
                                        public List<RelatedApprovalControlValue>? RelatedApprovals { get; set; }

                                        /// <summary>
                                        /// 获取或设置 Formula 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("formula")]
                                        [System.Text.Json.Serialization.JsonPropertyName("formula")]
                                        public FormulaControlValue? Formula { get; set; }

                                        /// <summary>
                                        /// 获取或设置 BankAccount 控件值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("bank_account")]
                                        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
                                        public BankAccountControlValue? BankAccount { get; set; }
                                    }

                                    public class DateControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.DateControlValue
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
                                                public string? Description { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置时区信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("timezone_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("timezone_info")]
                                        public Types.Timezone? Timezone { get; set; }
                                    }

                                    public class SelectorControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.__zz__SelectorControlValue
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
                                                public string? Key { get; set; }

                                                /// <summary>
                                                /// 获取或设置选项值。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                                public List<MultiLangText>? Value { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置选项列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("options")]
                                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                                        public List<Types.Option>? OptionList { get; set; }
                                    }

                                    public class ContactControlValueAsUser : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.ContactControlValueAsUser
                                    {
                                    }

                                    public class ContactControlValueAsDepartment : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.ContactControlValueAsDepartment
                                    {
                                    }

                                    public class TipsControlValue
                                    {
                                        public static class Types
                                        {
                                            public class TipsContent : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.__zz__TipsContent
                                            {
                                                public static class Types
                                                {
                                                    public class Text
                                                    {
                                                        public static class Types
                                                        {
                                                            public class SubText : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.TipsContent.Types.Text.Types.__zz__SubText
                                                            {
                                                                public static class Types
                                                                {
                                                                    public class Content
                                                                    {
                                                                        public static class Types
                                                                        {
                                                                            public class PlainText : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.TipsContent.Types.Text.Types.SubText.Types.Content.Types.PlainText
                                                                            {
                                                                            }

                                                                            public class Link : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent.Types.Control.Types.TipsControlConfig.Types.TipsContent.Types.Text.Types.SubText.Types.Content.Types.Link
                                                                            {
                                                                            }
                                                                        }

                                                                        /// <summary>
                                                                        /// 获取或设置纯文本类型的内容信息。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("plain_text")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("plain_text")]
                                                                        public Types.PlainText? PlainText { get; set; }

                                                                        /// <summary>
                                                                        /// 获取或设置链接类型的内容信息。
                                                                        /// </summary>
                                                                        [Newtonsoft.Json.JsonProperty("link")]
                                                                        [System.Text.Json.Serialization.JsonPropertyName("link")]
                                                                        public Types.Link? Link { get; set; }
                                                                    }
                                                                }

                                                                /// <summary>
                                                                /// 获取或设置文本内容。
                                                                /// </summary>
                                                                [Newtonsoft.Json.JsonProperty("content")]
                                                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                                                public Types.Content? Content { get; set; }
                                                            }
                                                        }

                                                        /// <summary>
                                                        /// 获取或设置说明文字分段列表。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("sub_text")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("sub_text")]
                                                        public List<Types.SubText>? SubTextList { get; set; }
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置说明文字信息。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                public Types.Text? Text { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置说明文字列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tips_content")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tips_content")]
                                        public List<Types.TipsContent>? TipsList { get; set; }
                                    }

                                    public class FileControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.FileControlValue
                                    {
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
                                        public List<Types.TableDetail>? TableDetailList { get; set; }
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
                                        public Types.Selector? Selector { get; set; }

                                        /// <summary>
                                        /// 获取或设置假勤内容填写信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("attendance")]
                                        [System.Text.Json.Serialization.JsonPropertyName("attendance")]
                                        public Types.Attendance? Attendance { get; set; }
                                    }

                                    public class AttendanceControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.__zz__AttendanceControlValue
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
                                                    public class DayItem : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.AttendanceControlValue.Types.Slice.Types.DayItem
                                                    {
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
                                                public List<Types.DayItem>? DayItems { get; set; }

                                                /// <summary>
                                                /// 获取或设置总时长（单位：秒）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("duration")]
                                                [System.Text.Json.Serialization.JsonPropertyName("duration")]
                                                public int TotalDuration { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置时间选择范围。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("date_range")]
                                        [System.Text.Json.Serialization.JsonPropertyName("date_range")]
                                        public Types.DateRange? DateRange { get; set; }

                                        /// <summary>
                                        /// 获取或设置时长按天分片信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("slice_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("slice_info")]
                                        public Types.Slice? Slice { get; set; }
                                    }

                                    public class CheckinControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.CheckinControlValue
                                    {
                                    }

                                    public class DateRangeControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.DateRangeControlValue
                                    {
                                        public static class Types
                                        {
                                            public class Timezone : DateControlValue.Types.Timezone
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置时区信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("timezone_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("timezone_info")]
                                        public Types.Timezone? Timezone { get; set; }
                                    }

                                    public class LocationControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.LocationControlValue
                                    {
                                    }

                                    public class RelatedApprovalControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.RelatedApprovalControlValue
                                    {
                                        /// <summary>
                                        /// 获取或设置模板名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("template_names")]
                                        [System.Text.Json.Serialization.JsonPropertyName("template_names")]
                                        public List<MultiLangText>? TemplateName { get; set; }

                                        /// <summary>
                                        /// 获取或设置审批单名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string? Name { get; set; }

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

                                    public class FormulaControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.FormulaControlValue
                                    {
                                    }

                                    public class BankAccountControlValue : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.__zz__BankAccountControlValue
                                    {
                                        public static class Types
                                        {
                                            public class Bank : CgibinOAApplyEventRequest.Types.ApplyData.Types.ApplyContent.Types.BankAccountControlValue.Types.Bank
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置银行信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("bank")]
                                        [System.Text.Json.Serialization.JsonPropertyName("bank")]
                                        public Types.Bank? Bank { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置控件名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public List<MultiLangText>? Title { get; set; }

                                /// <summary>
                                /// 获取或设置控件值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public Types.Value? Value { get; set; }

                                /// <summary>
                                /// 获取或设置是否为必填项。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("require")]
                                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("require")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                                public bool? IsRequired { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置审批申请内容列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contents")]
                        [System.Text.Json.Serialization.JsonPropertyName("contents")]
                        public List<Types.ApplyContent>? ApplyContentList { get; set; }
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
                                public string? UserId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentid")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentid")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringConverter))]
                        public string? CommentId { get; set; }

                        /// <summary>
                        /// 获取或设置评论人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentUserInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentUserInfo")]
                        public Types.CommentUser? CommentUser { get; set; }

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentcontent")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentcontent")]
                        public string? Content { get; set; }

                        /// <summary>
                        /// 获取或设置评论内容附件 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public List<string>? MediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置评论时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commenttime")]
                        [System.Text.Json.Serialization.JsonPropertyName("commenttime")]
                        public long CreateTimestamp { get; set; }
                    }

                    public class Process
                    {
                        public static class Types
                        {
                            public class Node
                            {
                                public static class Types
                                {
                                    public class SubNode
                                    {
                                        /// <summary>
                                        /// 获取或设置处理人成员账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("userid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                        public string? UserId { get; set; }

                                        /// <summary>
                                        /// 获取或设置审批状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sp_yj")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sp_yj")]
                                        public int? ApproveStatus { get; set; }

                                        /// <summary>
                                        /// 获取或设置操作时间。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Sptime")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Sptime")]
                                        public long? ApproveTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置审批意见。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Speech")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Speech")]
                                        public string? Speech { get; set; }

                                        /// <summary>
                                        /// 获取或设置审批意见附件 MediaId 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("media_ids")]
                                        [System.Text.Json.Serialization.JsonPropertyName("media_ids")]
                                        public List<string>? AttachmentMediaIdList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置节点类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("node_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("node_type")]
                                public int NodeType { get; set; }

                                /// <summary>
                                /// 获取或设置节点状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sp_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("sp_status")]
                                public int? Status { get; set; }

                                /// <summary>
                                /// 获取或设置多人办理方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("apv_rel")]
                                [System.Text.Json.Serialization.JsonPropertyName("apv_rel")]
                                public int? ApproversRelation { get; set; }

                                /// <summary>
                                /// 获取或设置子节点列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sub_node_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("sub_node_list")]
                                public List<Types.SubNode>? SubNodeList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置节点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("node_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("node_list")]
                        public List<Types.Node>? NodeList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审批单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_no")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_no")]
                public string? ApprovalNumber { get; set; }

                /// <summary>
                /// 获取或设置审批单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_name")]
                public string? Name { get; set; }

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
                public string? TemplateId { get; set; }

                /// <summary>
                /// 获取或设置申请人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyer")]
                [System.Text.Json.Serialization.JsonPropertyName("applyer")]
                public Types.Applicant? Applicant { get; set; }

                /// <summary>
                /// 获取或设置批量申请人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("batch_applyer")]
                [System.Text.Json.Serialization.JsonPropertyName("batch_applyer")]
                public List<Types.BatchApplicant>? BatchApplicantList { get; set; }

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
                public List<Types.Notifier>? NotifyerList { get; set; }

                /// <summary>
                /// 获取或设置审批申请数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_data")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_data")]
                public Types.ApplyData? ApplyData { get; set; }

                /// <summary>
                /// 获取或设置审批流程列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_record")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_record")]
                public List<Types.Record>? RecordList { get; set; }

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comments")]
                [System.Text.Json.Serialization.JsonPropertyName("comments")]
                public List<Types.Comment>? CommentList { get; set; }

                /// <summary>
                /// 获取或设置审批流程信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("process_list")]
                [System.Text.Json.Serialization.JsonPropertyName("process_list")]
                public Types.Process? Process { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置审批单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Approval? Approval { get; set; }
    }
}
