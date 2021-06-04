using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corp/get_join_qrcode 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGetOpenApprovalDataResponse : WechatWorkResponse
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
                                        public ApprovalerItem[] Items { get; set; } = default!;
                                    }

                                    public class ApprovalerItem
                                    {
                                        /// <summary>
                                        /// 获取或设置审批人成员账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemUserId")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemUserId")]
                                        public string UserId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批人名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemName")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemName")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批人部门名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemParty")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemParty")]
                                        public string DepartmentName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审批人头像 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemImage")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemImage")]
                                        public string AvatarUrl { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置分支审批状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemStatus")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemStatus")]
                                        public int ApproveStatus { get; set; }

                                        /// <summary>
                                        /// 获取或设置分支审批时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemOpTime")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemOpTime")]
                                        public long? ApproveTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置审批意见。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ItemSpeech")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ItemSpeech")]
                                        public string? Speech { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置节点审批状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("NodeStatus")]
                                [System.Text.Json.Serialization.JsonPropertyName("NodeStatus")]
                                public int ApproveStatus { get; set; }

                                /// <summary>
                                /// 获取或设置节点审批方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("NodeAttr")]
                                [System.Text.Json.Serialization.JsonPropertyName("NodeAttr")]
                                public int ApproveType { get; set; }

                                /// <summary>
                                /// 获取或设置节点类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("NodeType")]
                                [System.Text.Json.Serialization.JsonPropertyName("NodeType")]
                                public int NodeType { get; set; }

                                /// <summary>
                                /// 获取或设置节点审批人列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Items")]
                                [System.Text.Json.Serialization.JsonPropertyName("Items")]
                                public Types.ApprovalerList ApprovalerList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置审批流程详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ApprovalNode")]
                        [System.Text.Json.Serialization.JsonPropertyName("ApprovalNode")]
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
                                [Newtonsoft.Json.JsonProperty("ItemUserId")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemUserId")]
                                public string UserId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置抄送人名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemName")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemName")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置抄送人部门名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemParty")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemParty")]
                                public string DepartmentName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置抄送人头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemImage")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemImage")]
                                public string AvatarUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置审批抄送列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("NotifyNode")]
                        [System.Text.Json.Serialization.JsonPropertyName("NotifyNode")]
                        public Types.Notifier[] NotifierList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置第三方审批单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ThirdNo")]
                [System.Text.Json.Serialization.JsonPropertyName("ThirdNo")]
                public string ThirdPartyApprovalNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务商审批模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OpenTemplateId")]
                [System.Text.Json.Serialization.JsonPropertyName("OpenTemplateId")]
                public string OpenTemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OpenSpName")]
                [System.Text.Json.Serialization.JsonPropertyName("OpenSpName")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OpenSpstatus")]
                [System.Text.Json.Serialization.JsonPropertyName("OpenSpstatus")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyTime")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyTime")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置申请人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUserId")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUserId")]
                public string ApplicantUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人成员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUsername")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUsername")]
                public string ApplicantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置提单部门名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUserParty")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUserParty")]
                public string ApplicantDepartmentName { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请人头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApplyUserImage")]
                [System.Text.Json.Serialization.JsonPropertyName("ApplyUserImage")]
                public string ApplicantAvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置审批信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApprovalNodes")]
                [System.Text.Json.Serialization.JsonPropertyName("ApprovalNodes")]
                public Types.ApprovalRecord ApprovalRecord { get; set; } = default!;

                /// <summary>
                /// 获取或设置抄送信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("NotifyNodes")]
                [System.Text.Json.Serialization.JsonPropertyName("NotifyNodes")]
                public Types.Notification Notification { get; set; } = default!;

                /// <summary>
                /// 获取或设置当前审批节点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ApproverStep")]
                [System.Text.Json.Serialization.JsonPropertyName("ApproverStep")]
                public int ApproverStep { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方审批单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Approval Approval { get; set; } = default!;
    }
}
