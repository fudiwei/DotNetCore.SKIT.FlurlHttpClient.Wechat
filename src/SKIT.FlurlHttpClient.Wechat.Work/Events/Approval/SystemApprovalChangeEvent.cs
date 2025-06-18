namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.sys_approval_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91815 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92633 ]]>
    /// </para>
    /// </summary>
    public class SystemApprovalChangeEvent : WechatWorkEvent
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
                        [Newtonsoft.Json.JsonProperty("UserId")]
                        [System.Text.Json.Serialization.JsonPropertyName("UserId")]
                        [System.Xml.Serialization.XmlElement("UserId")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置提单部门 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Party")]
                        [System.Text.Json.Serialization.JsonPropertyName("Party")]
                        [System.Xml.Serialization.XmlElement("Party")]
                        public long DepartmentId { get; set; }
                    }

                    public class Notifier
                    {
                        /// <summary>
                        /// 获取或设置抄送人成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("UserId")]
                        [System.Text.Json.Serialization.JsonPropertyName("UserId")]
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
                                        [Newtonsoft.Json.JsonProperty("UserId")]
                                        [System.Text.Json.Serialization.JsonPropertyName("UserId")]
                                        [System.Xml.Serialization.XmlElement("UserId")]
                                        public string UserId { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置审批人信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Approver")]
                                [System.Text.Json.Serialization.JsonPropertyName("Approver")]
                                [System.Xml.Serialization.XmlElement("Approver")]
                                public Types.Approver Approver { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分支审批状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SpStatus")]
                                [System.Text.Json.Serialization.JsonPropertyName("SpStatus")]
                                [System.Xml.Serialization.XmlElement("SpStatus")]
                                public int ApproveStatus { get; set; }

                                /// <summary>
                                /// 获取或设置分支审批时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SpTime")]
                                [System.Text.Json.Serialization.JsonPropertyName("SpTime")]
                                [System.Xml.Serialization.XmlElement("SpTime", IsNullable = true)]
                                public long? ApproveTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Speech")]
                                [System.Text.Json.Serialization.JsonPropertyName("Speech")]
                                [System.Xml.Serialization.XmlElement("Speech", IsNullable = true)]
                                public string? Speech { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见附件 MediaId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Attach")]
                                [System.Text.Json.Serialization.JsonPropertyName("Attach")]
                                [System.Xml.Serialization.XmlElement("Attach", Type = typeof(string), IsNullable = true)]
                                public string[]? AttachmentMediaIdList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置节点审批状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("SpStatus")]
                        [System.Text.Json.Serialization.JsonPropertyName("SpStatus")]
                        [System.Xml.Serialization.XmlElement("SpStatus")]
                        public int ApproveStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审批方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ApproverAttr")]
                        [System.Text.Json.Serialization.JsonPropertyName("ApproverAttr")]
                        [System.Xml.Serialization.XmlElement("ApproverAttr")]
                        public int ApproveType { get; set; }

                        /// <summary>
                        /// 获取或设置审批流程详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Details")]
                        [System.Text.Json.Serialization.JsonPropertyName("Details")]
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
                                [Newtonsoft.Json.JsonProperty("UserId")]
                                [System.Text.Json.Serialization.JsonPropertyName("UserId")]
                                [System.Xml.Serialization.XmlElement("UserId")]
                                public string UserId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CommentId")]
                        [System.Text.Json.Serialization.JsonPropertyName("CommentId")]
                        [System.Xml.Serialization.XmlElement("CommentId")]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CommentUserInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("CommentUserInfo")]
                        [System.Xml.Serialization.XmlElement("CommentUserInfo")]
                        public Types.CommentUser CommentUser { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CommentContent")]
                        [System.Text.Json.Serialization.JsonPropertyName("CommentContent")]
                        [System.Xml.Serialization.XmlElement("CommentContent")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容附件 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Attach")]
                        [System.Text.Json.Serialization.JsonPropertyName("Attach")]
                        [System.Xml.Serialization.XmlElement("Attach", Type = typeof(string))]
                        public string[] MediaIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CommentTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("CommentTime")]
                        [System.Xml.Serialization.XmlElement("CommentTime")]
                        public long CreateTimestamp { get; set; }
                    }

                    public class Process
                    {
                        public static class Types
                        {
                            public class Node
                            {
                                /// <summary>
                                /// 获取或设置节点类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("NodeType")]
                                [System.Text.Json.Serialization.JsonPropertyName("NodeType")]
                                [System.Xml.Serialization.XmlElement("NodeType")]
                                public int NodeType { get; set; }

                                /// <summary>
                                /// 获取或设置节点状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SpStatus")]
                                [System.Text.Json.Serialization.JsonPropertyName("SpStatus")]
                                [System.Xml.Serialization.XmlElement("SpStatus", IsNullable = true)]
                                public int? Status { get; set; }

                                /// <summary>
                                /// 获取或设置多人办理方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ApvRel")]
                                [System.Text.Json.Serialization.JsonPropertyName("ApvRel")]
                                [System.Xml.Serialization.XmlElement("ApvRel", IsNullable = true)]
                                public int? ApproversRelation { get; set; }

                                /// <summary>
                                /// 获取或设置子节点列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SubNodeList")]
                                [System.Text.Json.Serialization.JsonPropertyName("SubNodeList")]
                                [System.Xml.Serialization.XmlElement("SubNodeList", Type = typeof(Types.SubNode))]
                                public Types.SubNode[] SubNodeList { get; set; } = default!;
                            }

                            public class SubNode
                            {
                                public static class Types
                                {
                                    public class User
                                    {
                                        /// <summary>
                                        /// 获取或设置处理人成员账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("UserId")]
                                        [System.Text.Json.Serialization.JsonPropertyName("UserId")]
                                        [System.Xml.Serialization.XmlElement("UserId")]
                                        public string UserId { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置处理人信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("UserInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("UserInfo")]
                                [System.Xml.Serialization.XmlElement("UserInfo")]
                                public Types.User User { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审批状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("SpYj")]
                                [System.Text.Json.Serialization.JsonPropertyName("SpYj")]
                                [System.Xml.Serialization.XmlElement("SpYj", IsNullable = true)]
                                public int? ApproveStatus { get; set; }

                                /// <summary>
                                /// 获取或设置操作时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Sptime")]
                                [System.Text.Json.Serialization.JsonPropertyName("Sptime")]
                                [System.Xml.Serialization.XmlElement("Sptime", IsNullable = true)]
                                public long? ApproveTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Speech")]
                                [System.Text.Json.Serialization.JsonPropertyName("Speech")]
                                [System.Xml.Serialization.XmlElement("Speech", IsNullable = true)]
                                public string? Speech { get; set; }

                                /// <summary>
                                /// 获取或设置审批意见附件 MediaId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("MediaIds")]
                                [System.Text.Json.Serialization.JsonPropertyName("MediaIds")]
                                [System.Xml.Serialization.XmlElement("MediaIds", Type = typeof(string), IsNullable = true)]
                                public string[]? AttachmentMediaIdList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置节点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("NodeList")]
                        [System.Text.Json.Serialization.JsonPropertyName("NodeList")]
                        [System.Xml.Serialization.XmlElement("NodeList", Type = typeof(Types.Node))]
                        public Types.Node[] NodeList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置审批申请状态变化类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("StatuChangeEvent")]
                [System.Text.Json.Serialization.JsonPropertyName("StatuChangeEvent")]
                [System.Xml.Serialization.XmlElement("StatuChangeEvent")]
                public int StatusChangeEvent { get; set; }

                /// <summary>
                /// 获取或设置审批单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("SpNo")]
                [System.Text.Json.Serialization.JsonPropertyName("SpNo")]
                [System.Xml.Serialization.XmlElement("SpNo")]
                public string ApprovalNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("SpName")]
                [System.Text.Json.Serialization.JsonPropertyName("SpName")]
                [System.Xml.Serialization.XmlElement("SpName")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("SpStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("SpStatus")]
                [System.Xml.Serialization.XmlElement("SpStatus")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审批模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TemplateId")]
                [System.Text.Json.Serialization.JsonPropertyName("TemplateId")]
                [System.Xml.Serialization.XmlElement("TemplateId")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Applyer")]
                [System.Text.Json.Serialization.JsonPropertyName("Applyer")]
                [System.Xml.Serialization.XmlElement("Applyer")]
                public Types.Applicant Applicant { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyTime")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyTime")]
                [System.Xml.Serialization.XmlElement("ApplyTime")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置抄送人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Notifyer")]
                [System.Text.Json.Serialization.JsonPropertyName("Notifyer")]
                [System.Xml.Serialization.XmlElement("Notifyer", Type = typeof(Types.Notifier))]
                public Types.Notifier[]? NotifyerList { get; set; }

                /// <summary>
                /// 获取或设置审批流程列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("SpRecord")]
                [System.Text.Json.Serialization.JsonPropertyName("SpRecord")]
                [System.Xml.Serialization.XmlElement("SpRecord", Type = typeof(Types.Record))]
                public Types.Record[] RecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Comments")]
                [System.Text.Json.Serialization.JsonPropertyName("Comments")]
                [System.Xml.Serialization.XmlElement("Comments", Type = typeof(Types.Comment))]
                public Types.Comment[] CommentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批流程信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ProcessList")]
                [System.Text.Json.Serialization.JsonPropertyName("ProcessList")]
                [System.Xml.Serialization.XmlElement("ProcessList", IsNullable = true)]
                public Types.Process? Process { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置审批单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApprovalInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("ApprovalInfo")]
        [System.Xml.Serialization.XmlElement("ApprovalInfo")]
        public Types.Approval Approval { get; set; } = default!;
    }
}
