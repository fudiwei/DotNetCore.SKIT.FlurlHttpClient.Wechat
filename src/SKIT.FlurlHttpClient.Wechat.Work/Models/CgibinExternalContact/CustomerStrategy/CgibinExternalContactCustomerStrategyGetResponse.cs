using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_strategy/get 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerStrategyGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Strategy
            {
                public static class Types
                {
                    public class Privilege
                    {
                        /// <summary>
                        /// 获取或设置是否可以查看客户列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_customer_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_customer_list")]
                        public bool EnableViewCustomerList { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以查看客户统计数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_customer_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_customer_data")]
                        public bool EnableViewCustomerData { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以查看群聊列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_room_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_room_list")]
                        public bool EnableViewRoomList { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以使用联系我。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_me")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_me")]
                        public bool EnableContactMe { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以加入群聊。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("join_room")]
                        [System.Text.Json.Serialization.JsonPropertyName("join_room")]
                        public bool EnableJoinRoom { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以分享客户给其他成员。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_customer")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_customer")]
                        public bool EnableShareCustomer { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以分配离职成员客户。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("oper_resign_customer")]
                        [System.Text.Json.Serialization.JsonPropertyName("oper_resign_customer")]
                        public bool EnableResignCustomer { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以分配离职成员客户群。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("oper_resign_group")]
                        [System.Text.Json.Serialization.JsonPropertyName("oper_resign_group")]
                        public bool EnableResignGroup { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以给企业客户发送消息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_customer_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_customer_msg")]
                        public bool EnableSendCustomerMessage { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以配置欢迎语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("edit_welcome_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("edit_welcome_msg")]
                        public bool EnableEditWelcomeMessage { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以查看成员联系客户统计。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_behavior_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_behavior_data")]
                        public bool EnableViewBehaviorData { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以查看群聊数据统计。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_room_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_room_data")]
                        public bool EnableViewRoomData { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以发送消息到企业的客户群。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_group_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_group_msg")]
                        public bool EnableSendGroupMessage { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以对企业客户群进行去重。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_deduplication")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_deduplication")]
                        public bool EnableRoomDeduplication { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以配置快捷回复。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rapid_reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("rapid_reply")]
                        public bool EnableRapidReply { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以转接在职成员的客户。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("onjob_customer_transfer")]
                        [System.Text.Json.Serialization.JsonPropertyName("onjob_customer_transfer")]
                        public bool EnableOnJobCustomerTransfer { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以编辑企业成员防骚扰规则。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("edit_anti_spam_rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("edit_anti_spam_rule")]
                        public bool EnableEditAntiSpamRule { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以导出客户列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("export_customer_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("export_customer_list")]
                        public bool EnableExportCustomerList { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以导出成员客户统计。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("export_customer_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("export_customer_data")]
                        public bool EnableExportCustomerData { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以导出客户群列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("export_customer_group_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("export_customer_group_list")]
                        public bool EnableExportCustomerGroupList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置规则组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy_id")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
                public int StrategyId { get; set; }

                /// <summary>
                /// 获取或设置父规则组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                public int ParentStrategyId { get; set; }

                /// <summary>
                /// 获取或设置规则组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy_name")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置管理员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admin_list")]
                [System.Text.Json.Serialization.JsonPropertyName("admin_list")]
                public string[] AdminUserIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置权限信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privilege")]
                [System.Text.Json.Serialization.JsonPropertyName("privilege")]
                public Types.Privilege Privilege { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy")]
        public Types.Strategy Strategy { get; set; } = default!;
    }
}
