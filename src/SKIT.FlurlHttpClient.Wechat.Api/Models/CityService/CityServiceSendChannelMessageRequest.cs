using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/sendchannelmsg 接口的请求。</para>
    /// </summary>
    public class CityServiceSendChannelMessageRequest : WechatApiRequest, IInferable<CityServiceSendChannelMessageRequest, CityServiceSendChannelMessageResponse>
    {
        public static class Types
        {
            /// <summary>
            /// 业务参数基类。
            /// </summary>
            public class BusinessInfo
            {
                public static class Types
                {
                    public class RedirectPage
                    {
                        /// <summary>
                        /// 获取或设置页面类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_type")]
                        public string PageType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置网址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string? AppId { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fullpath")]
                        [System.Text.Json.Serialization.JsonPropertyName("fullpath")]
                        public string? PagePath { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置跳转页面信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("redirect_page")]
                [System.Text.Json.Serialization.JsonPropertyName("redirect_page")]
                public Types.RedirectPage? RedirectPage { get; set; }

                /// <summary>
                /// 获取或设置扩展字段。
                /// </summary>
                [Newtonsoft.Json.JsonExtensionData]
                [System.Text.Json.Serialization.JsonExtensionData]
                public IDictionary<string, object>? ExtensionData { get; set; }
            }

            /// <summary>
            /// 就医助手业务（<see cref="BusinessId"/>: 150）参数。
            /// </summary>
            public class BusinessInfoAs150 : BusinessInfo
            {
                /// <summary>
                /// 获取或设置取药地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置住院号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admission_no")]
                [System.Text.Json.Serialization.JsonPropertyName("admission_no")]
                public string? AdmissionNumber { get; set; }

                /// <summary>
                /// 获取或设置入院时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admission_time")]
                [System.Text.Json.Serialization.JsonPropertyName("admission_time")]
                public string? AdmissionTimeString { get; set; }

                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int? Amount { get; set; }

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_status")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_status")]
                public string? ApplyStatus { get; set; }

                /// <summary>
                /// 获取或设置预约日期字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appointment_date")]
                [System.Text.Json.Serialization.JsonPropertyName("appointment_date")]
                public string? AppointmentDateString { get; set; }

                /// <summary>
                /// 获取或设置预约进度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appointment_progress")]
                [System.Text.Json.Serialization.JsonPropertyName("appointment_progress")]
                public string? AppointmentProgress { get; set; }

                /// <summary>
                /// 获取或设置预约时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appointment_time")]
                [System.Text.Json.Serialization.JsonPropertyName("appointment_time")]
                public string? AppointmentTimeString { get; set; }

                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public string? AuditStatus { get; set; }

                /// <summary>
                /// 获取或设置余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                public int? Balance { get; set; }

                /// <summary>
                /// 获取或设置床位状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bed_status")]
                [System.Text.Json.Serialization.JsonPropertyName("bed_status")]
                public string? BedStatus { get; set; }

                /// <summary>
                /// 获取或设置清单日期字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checklist_date")]
                [System.Text.Json.Serialization.JsonPropertyName("checklist_date")]
                public string? ChecklistDateString { get; set; }

                /// <summary>
                /// 获取或设置结算时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clear_time")]
                [System.Text.Json.Serialization.JsonPropertyName("clear_time")]
                public string? ClearTimeString { get; set; }

                /// <summary>
                /// 获取或设置评价状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_status")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_status")]
                public string? CommentStatus { get; set; }

                /// <summary>
                /// 获取或设置危急值项目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("critical_value_name")]
                [System.Text.Json.Serialization.JsonPropertyName("critical_value_name")]
                public string? CriticalValueName { get; set; }

                /// <summary>
                /// 获取或设置危急值结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("critical_value_result")]
                [System.Text.Json.Serialization.JsonPropertyName("critical_value_result")]
                public string? CriticalValueResult { get; set; }

                /// <summary>
                /// 获取或设置配送内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliver_content")]
                [System.Text.Json.Serialization.JsonPropertyName("deliver_content")]
                public string? DeliverContent { get; set; }

                /// <summary>
                /// 获取或设置配送单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliver_no")]
                [System.Text.Json.Serialization.JsonPropertyName("deliver_no")]
                public string? DeliverNumber { get; set; }

                /// <summary>
                /// 获取或设置科室名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_name")]
                [System.Text.Json.Serialization.JsonPropertyName("department_name")]
                public string? DepartmentName { get; set; }

                /// <summary>
                /// 获取或设置押金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deposit")]
                [System.Text.Json.Serialization.JsonPropertyName("deposit")]
                public int? Deposit { get; set; }

                /// <summary>
                /// 获取或设置检出时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detect_time")]
                [System.Text.Json.Serialization.JsonPropertyName("detect_time")]
                public string? DetectTimeString { get; set; }

                /// <summary>
                /// 获取或设置医嘱内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doc_advice")]
                [System.Text.Json.Serialization.JsonPropertyName("doc_advice")]
                public string? DoctorAdvice { get; set; }

                /// <summary>
                /// 获取或设置医生姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doc_name")]
                [System.Text.Json.Serialization.JsonPropertyName("doc_name")]
                public string? DoctorName { get; set; }

                /// <summary>
                /// 获取或设置办理时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enter_time")]
                [System.Text.Json.Serialization.JsonPropertyName("enter_time")]
                public string? EnterTimeString { get; set; }

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }

                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fee")]
                [System.Text.Json.Serialization.JsonPropertyName("fee")]
                public int? Fee { get; set; }

                /// <summary>
                /// 获取或设置文档类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_type")]
                [System.Text.Json.Serialization.JsonPropertyName("file_type")]
                public string? FileType { get; set; }

                /// <summary>
                /// 获取或设置随访状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follow_up_status")]
                [System.Text.Json.Serialization.JsonPropertyName("follow_up_status")]
                public string? FollowUpStatus { get; set; }

                /// <summary>
                /// 获取或设置住院医院。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hospital_name")]
                [System.Text.Json.Serialization.JsonPropertyName("hospital_name")]
                public string? HospitalName { get; set; }

                /// <summary>
                /// 获取或设置转入医院。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("in_hospital")]
                [System.Text.Json.Serialization.JsonPropertyName("in_hospital")]
                public string? InHospital { get; set; }

                /// <summary>
                /// 获取或设置住院状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("in_hospital_state")]
                [System.Text.Json.Serialization.JsonPropertyName("in_hospital_state")]
                public string? InHospitalState { get; set; }

                /// <summary>
                /// 获取或设置发起方。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("initiator")]
                [System.Text.Json.Serialization.JsonPropertyName("initiator")]
                public string? Initiator { get; set; }

                /// <summary>
                /// 获取或设置发起时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("init_time")]
                [System.Text.Json.Serialization.JsonPropertyName("init_time")]
                public string? InitTimeString { get; set; }

                /// <summary>
                /// 获取或设置问诊时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inquiry_time")]
                [System.Text.Json.Serialization.JsonPropertyName("inquiry_time")]
                public string? InquiryTimeString { get; set; }

                /// <summary>
                /// 获取或设置检查项目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspect_item")]
                [System.Text.Json.Serialization.JsonPropertyName("inspect_item")]
                public string? InspectItem { get; set; }

                /// <summary>
                /// 获取或设置检查地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspect_place")]
                [System.Text.Json.Serialization.JsonPropertyName("inspect_place")]
                public string? InspectPlace { get; set; }

                /// <summary>
                /// 获取或设置检查时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspect_time")]
                [System.Text.Json.Serialization.JsonPropertyName("inspect_time")]
                public string? InspectTimeString { get; set; }

                /// <summary>
                /// 获取或设置体检项目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("medical_item")]
                [System.Text.Json.Serialization.JsonPropertyName("medical_item")]
                public string? MedicalItem { get; set; }

                /// <summary>
                /// 获取或设置体检地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("medical_place")]
                [System.Text.Json.Serialization.JsonPropertyName("medical_place")]
                public string? MedicalPlace { get; set; }

                /// <summary>
                /// 获取或设置体检时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("medical_time")]
                [System.Text.Json.Serialization.JsonPropertyName("medical_time")]
                public string? MedicalTimeString { get; set; }

                /// <summary>
                /// 获取或设置药品内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("medicine")]
                [System.Text.Json.Serialization.JsonPropertyName("medicine")]
                public string? Medicine { get; set; }

                /// <summary>
                /// 获取或设置药品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("medicine_name")]
                [System.Text.Json.Serialization.JsonPropertyName("medicine_name")]
                public string? MedicineName { get; set; }

                /// <summary>
                /// 获取或设置用药提醒。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("medicine_remind")]
                [System.Text.Json.Serialization.JsonPropertyName("medicine_remind")]
                public string? MedicineRemind { get; set; }

                /// <summary>
                /// 获取或设置就医须知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("memo")]
                [System.Text.Json.Serialization.JsonPropertyName("memo")]
                public string? Memo { get; set; }

                /// <summary>
                /// 获取或设置转出医院。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_hospital")]
                [System.Text.Json.Serialization.JsonPropertyName("out_hospital")]
                public string? OutHospital { get; set; }

                /// <summary>
                /// 获取或设置患者就诊卡号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pat_hospital_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pat_hospital_id")]
                public string? PatientHospitalId { get; set; }

                /// <summary>
                /// 获取或设置患者姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pat_name")]
                [System.Text.Json.Serialization.JsonPropertyName("pat_name")]
                public string? PatientName { get; set; }

                /// <summary>
                /// 获取或设置缴费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                public int? PayAmount { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置处方内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prescription_content")]
                [System.Text.Json.Serialization.JsonPropertyName("prescription_content")]
                public string? PrescriptionContent { get; set; }

                /// <summary>
                /// 获取或设置开方时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rescription_time")]
                [System.Text.Json.Serialization.JsonPropertyName("rescription_time")]
                public string? PrescriptionTimeString { get; set; }

                /// <summary>
                /// 获取或设置领取方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_way")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_way")]
                public string? ReceiveWay { get; set; }

                /// <summary>
                /// 获取或设置接诊状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reception_status")]
                [System.Text.Json.Serialization.JsonPropertyName("reception_status")]
                public string? ReceptionStatus { get; set; }

                /// <summary>
                /// 获取或设置待充值金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recharge_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("recharge_amount")]
                public int? RechargeAmount { get; set; }

                /// <summary>
                /// 获取或设置可退余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refundable_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refundable_amount")]
                public int? RefundableBalance { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int? RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置退款结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_result")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_result")]
                public string? RefundResult { get; set; }

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_status")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                public string? RefundStatus { get; set; }

                /// <summary>
                /// 获取或设置拒诊原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                public string? RejectReason { get; set; }

                /// <summary>
                /// 获取或设置回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_content")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_content")]
                public string? ReplyContent { get; set; }

                /// <summary>
                /// 获取或设置回复时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_time")]
                public string? ReplyTimeString { get; set; }

                /// <summary>
                /// 获取或设置复诊计划。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("revisit_plan")]
                [System.Text.Json.Serialization.JsonPropertyName("revisit_plan")]
                public string? RevisitPlan { get; set; }

                /// <summary>
                /// 获取或设置签署状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_status")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_status")]
                public string? SignStatus { get; set; }

                /// <summary>
                /// 获取或设置停诊原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stop_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
                public string? StopReason { get; set; }

                /// <summary>
                /// 获取或设置手术医生。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("surgery_doc")]
                [System.Text.Json.Serialization.JsonPropertyName("surgery_doc")]
                public string? SuegeryDoctor { get; set; }

                /// <summary>
                /// 获取或设置手术名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suegery_name")]
                [System.Text.Json.Serialization.JsonPropertyName("suegery_name")]
                public string? SuegeryName { get; set; }

                /// <summary>
                /// 获取或设置手术时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("surgery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("surgery_time")]
                public string? SuegeryTimeString { get; set; }

                /// <summary>
                /// 获取或设置手术科室。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("surgery_department")]
                [System.Text.Json.Serialization.JsonPropertyName("surgery_department")]
                public string? SurgeryDepartment { get; set; }

                /// <summary>
                /// 获取或设置手术进度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("surgery_stage")]
                [System.Text.Json.Serialization.JsonPropertyName("surgery_stage")]
                public string? SurgeryStage { get; set; }

                /// <summary>
                /// 获取或设置开票日期字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_date")]
                public string? TicketDateString { get; set; }

                /// <summary>
                /// 获取或设置开票时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_time")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_time")]
                public long? TicketTimestamp { get; set; }

                /// <summary>
                /// 获取或设置就医须知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tips")]
                [System.Text.Json.Serialization.JsonPropertyName("tips")]
                public string? Tips { get; set; }

                /// <summary>
                /// 获取或设置待办事项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("todo")]
                [System.Text.Json.Serialization.JsonPropertyName("todo")]
                public string? Todo { get; set; }

                /// <summary>
                /// 获取或设置交易金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_amount")]
                public int? TradeAmount { get; set; }

                /// <summary>
                /// 获取或设置交易时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_time")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_time")]
                public long? TradeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置转诊状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_status")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_status")]
                public string? TransferStatus { get; set; }

                /// <summary>
                /// 获取或设置候诊状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wait_status")]
                [System.Text.Json.Serialization.JsonPropertyName("wait_status")]
                public string? WaitStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务方订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置业务方消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置业务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_id")]
        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
        public int BusinessId { get; set; }

        /// <summary>
        /// 获取或设置业务字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_info")]
        [System.Text.Json.Serialization.JsonPropertyName("business_info")]
        public Types.BusinessInfo? BusinessInfo { get; set; }
    }
}
