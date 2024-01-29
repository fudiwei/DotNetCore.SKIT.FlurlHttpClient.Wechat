namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_approval_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90269 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93798 </para>
    /// </summary>
    public class OpenApprovalChangeEvent : WechatWorkEvent
    {
        public static class Types
        {
            public class Approval
            {
                public static class Types
                {
                    public class ApprovalRecord
                    {
                        public static class Types
                        {
                            public class RecordDetail
                            {
                                public static class Types
                                {
                                    public class ApprovalerList
                                    {
                                        /// <summary>
                                        /// 获取或设置审批人列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Item")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Item")]
                                        [System.Xml.Serialization.XmlElement("Item", typeof(ApprovalerItem))]
                                        public ApprovalerItem[] Items { get; set; } = default!;
                                    }

                                    public class ApprovalerItem
                                    {
                                        /// <summary>
                                        /// 获取或设置审批人成员账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemUserid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemUserid")]
                                        [System.Xml.Serialization.XmlElement("ItemUserid")]
                                        public string UserId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批人名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemName")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemName")]
                                        [System.Xml.Serialization.XmlElement("ItemName")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批人部门名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemParty")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemParty")]
                                        [System.Xml.Serialization.XmlElement("ItemParty")]
                                        public string DepartmentName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批人头像 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemImage")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemImage")]
                                        [System.Xml.Serialization.XmlElement("ItemImage")]
                                        public string AvatarUrl { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置分支审批状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemStatus")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemStatus")]
                                        [System.Xml.Serialization.XmlElement("ItemStatus")]
                                        public int ApproveStatus { get; set; }

                                        /// <summary>
                                        /// 获取或设置分支审批时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemOpTime")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemOpTime")]
                                        [System.Xml.Serialization.XmlElement("ItemOpTime", IsNullable = true)]
                                        public long? ApproveTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置审批意见。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemSpeech")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemSpeech")]
                                        [System.Xml.Serialization.XmlElement("ItemSpeech", IsNullable = true)]
                                        public string? Speech { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置节点审批状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("NodeStatus")]
                                [System.Text.Json.Serialization.JsonPropertyName("NodeStatus")]
                                [System.Xml.Serialization.XmlElement("NodeStatus")]
                                public int ApproveStatus { get; set; }

                                /// <summary>
                                /// 获取或设置节点审批方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("NodeAttr")]
                                [System.Text.Json.Serialization.JsonPropertyName("NodeAttr")]
                                [System.Xml.Serialization.XmlElement("NodeAttr")]
                                public int ApproveType { get; set; }

                                /// <summary>
                                /// 获取或设置节点类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("NodeType")]
                                [System.Text.Json.Serialization.JsonPropertyName("NodeType")]
                                [System.Xml.Serialization.XmlElement("NodeType")]
                                public int NodeType { get; set; }

                                /// <summary>
                                /// 获取或设置节点审批人列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Items")]
                                [System.Text.Json.Serialization.JsonPropertyName("Items")]
                                [System.Xml.Serialization.XmlElement("Items")]
                                public Types.ApprovalerList ApprovalerList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置审批流程详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ApprovalNode")]
                        [System.Text.Json.Serialization.JsonPropertyName("ApprovalNode")]
                        [System.Xml.Serialization.XmlElement("ApprovalNode", typeof(Types.RecordDetail))]
                        public Types.RecordDetail[] RecordDetailList { get; set; } = default!;
                    }

                    public class Notification
                    {
                        public static class Types
                        {
                            public class Notifier
                            {
                                /// <summary>
                                /// 获取或设置抄送人成员账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemUserid")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemUserid")]
                                [System.Xml.Serialization.XmlElement("ItemUserid")]
                                public string UserId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置抄送人名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemName")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemName")]
                                [System.Xml.Serialization.XmlElement("ItemName")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置抄送人部门名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemParty")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemParty")]
                                [System.Xml.Serialization.XmlElement("ItemParty")]
                                public string DepartmentName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置抄送人头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemImage")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemImage")]
                                [System.Xml.Serialization.XmlElement("ItemImage")]
                                public string AvatarUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置审批抄送列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("NotifyNode")]
                        [System.Text.Json.Serialization.JsonPropertyName("NotifyNode")]
                        [System.Xml.Serialization.XmlElement("NotifyNode", typeof(Types.Notifier))]
                        public Types.Notifier[] NotifierList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置第三方审批单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ThirdNo")]
                [System.Text.Json.Serialization.JsonPropertyName("ThirdNo")]
                [System.Xml.Serialization.XmlElement("ThirdNo")]
                public string ThirdPartyApprovalNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务商审批模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OpenTemplateId")]
                [System.Text.Json.Serialization.JsonPropertyName("OpenTemplateId")]
                [System.Xml.Serialization.XmlElement("OpenTemplateId")]
                public string OpenTemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OpenSpName")]
                [System.Text.Json.Serialization.JsonPropertyName("OpenSpName")]
                [System.Xml.Serialization.XmlElement("OpenSpName")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OpenSpStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("OpenSpStatus")]
                [System.Xml.Serialization.XmlElement("OpenSpStatus")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyTime")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyTime")]
                [System.Xml.Serialization.XmlElement("ApplyTime")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置申请人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUserId")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUserId")]
                [System.Xml.Serialization.XmlElement("ApplyUserId")]
                public string ApplicantUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人成员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUserName")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUserName")]
                [System.Xml.Serialization.XmlElement("ApplyUserName")]
                public string ApplicantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置提单部门名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUserParty")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUserParty")]
                [System.Xml.Serialization.XmlElement("ApplyUserParty")]
                public string ApplicantDepartmentName { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUserImage")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUserImage")]
                [System.Xml.Serialization.XmlElement("ApplyUserImage")]
                public string ApplicantAvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApprovalNodes")]
                [System.Text.Json.Serialization.JsonPropertyName("ApprovalNodes")]
                [System.Xml.Serialization.XmlElement("ApprovalNodes")]
                public Types.ApprovalRecord ApprovalRecord { get; set; } = default!;

                /// <summary>
                /// 获取或设置抄送信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("NotifyNodes")]
                [System.Text.Json.Serialization.JsonPropertyName("NotifyNodes")]
                [System.Xml.Serialization.XmlElement("NotifyNodes")]
                public Types.Notification Notification { get; set; } = default!;

                /// <summary>
                /// 获取或设置当前审批节点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApproverStep")]
                [System.Text.Json.Serialization.JsonPropertyName("ApproverStep")]
                [System.Xml.Serialization.XmlElement("ApproverStep")]
                public int ApproverStep { get; set; }
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
        /// 获取或设置第三方审批单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApprovalInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("ApprovalInfo")]
        [System.Xml.Serialization.XmlElement("ApprovalInfo")]
        public Types.Approval Approval { get; set; } = default!;
    }
}
