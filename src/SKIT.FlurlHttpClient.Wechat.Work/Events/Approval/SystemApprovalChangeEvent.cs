using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.sys_approval_change 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91815 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92633 </para>
    /// </summary>
    public class SystemApprovalChangeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
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
                        [System.Xml.Serialization.XmlElement("UserId")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置提单部门 ID。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Party")]
                        public int DepartmentId { get; set; }
                    }

                    public class Notifier
                    {
                        /// <summary>
                        /// 获取或设置抄送人成员账号。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("UserId")]
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
                                [System.Xml.Serialization.XmlElement("Approver")]
                                public Types.Approver Approver { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分支审批状态。
                                /// </summary>
                                [System.Xml.Serialization.XmlElement("SpStatus")]
                                public int ApproveStatus { get; set; }

                                /// <summary>
                                /// 获取或设置分支审批时间戳。
                                /// </summary>
                                [System.Xml.Serialization.XmlElement("SpTime", IsNullable = true)]
                                public long? ApproveTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见。
                                /// </summary>
                                [System.Xml.Serialization.XmlElement("Speech", IsNullable = true)]
                                public string? Speech { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见附件 MediaId 列表。
                                /// </summary>
                                [System.Xml.Serialization.XmlElement("Attach", Type = typeof(string), IsNullable = true)]
                                public string[]? SpeechMediaIdList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置节点审批状态。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("SpStatus")]
                        public int ApproveStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审批方式。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("ApproverAttr")]
                        public int ApproveType { get; set; }

                        /// <summary>
                        /// 获取或设置审批流程详情列表。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Details", typeof(Types.RecordDetail))]
                        public Types.RecordDetail[] DetailList { get; set; } = default!;
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
                                [System.Xml.Serialization.XmlElement("UserId")]
                                public string UserId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("CommentId")]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论人信息。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("CommentUserInfo")]
                        public Types.CommentUser CommentUser { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("CommentContent")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容附件 MediaId 列表。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("Attach", Type = typeof(string))]
                        public string[] MediaIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论时间戳。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("CommentTime")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审批申请状态变化类型。
                /// </summary>
                [System.Xml.Serialization.XmlElement("StatuChangeEvent")]
                public int StatusChangeEvent { get; set; }

                /// <summary>
                /// 获取或设置审批单号。
                /// </summary>
                [System.Xml.Serialization.XmlElement("SpNo")]
                public string ApprovalNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单名称。
                /// </summary>
                [System.Xml.Serialization.XmlElement("SpName")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单状态。
                /// </summary>
                [System.Xml.Serialization.XmlElement("SpStatus")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审批模板 ID。
                /// </summary>
                [System.Xml.Serialization.XmlElement("TemplateId")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人信息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Applyer")]
                public Types.Applicant Applicant { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ApplyTime")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置抄送人列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Notifyer", Type = typeof(Types.Notifier))]
                public Types.Notifier[]? NotifyerList { get; set; }

                /// <summary>
                /// 获取或设置审批流程列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("SpRecord", Type = typeof(Types.Record))]
                public Types.Record[] RecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Comments", Type = typeof(Types.Comment))]
                public Types.Comment[] CommentList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置审批单信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ApprovalInfo")]
        public Types.Approval Approval { get; set; } = default!;
    }
}
