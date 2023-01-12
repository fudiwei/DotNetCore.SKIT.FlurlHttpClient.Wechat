namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/get_servicer_statistic 接口的响应。</para>
    /// </summary>
    public class CgibinKfGetServicerStatisticResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Statistic
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置咨询会话数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("session_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("session_cnt")]
                        public int SessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置咨询客户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_cnt")]
                        public int CustomerCount { get; set; }

                        /// <summary>
                        /// 获取或设置咨询消息数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_msg_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_msg_cnt")]
                        public int CustomerMessageCount { get; set; }

                        /// <summary>
                        /// 获取或设置人工回复率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_rate")]
                        public double ReplyRate { get; set; }

                        /// <summary>
                        /// 获取或设置平均首次响应时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_reply_average_sec")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_reply_average_sec")]
                        public int FirstReplyAverageSeconds { get; set; }

                        /// <summary>
                        /// 获取或设置满意度评价发送数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("satisfaction_investgate_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("satisfaction_investgate_cnt")]
                        public int SatisfactionInvestgateCount { get; set; }

                        /// <summary>
                        /// 获取或设置满意度参评率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("satisfaction_participation_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("satisfaction_participation_rate")]
                        public double SatisfactionParticipationRate { get; set; }

                        /// <summary>
                        /// 获取或设置“满意”评价占比。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("satisfied_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("satisfied_rate")]
                        public double SatisfiedRate { get; set; }

                        /// <summary>
                        /// 获取或设置“一般”评价占比。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("middling_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("middling_rate")]
                        public double MiddlingRate { get; set; }

                        /// <summary>
                        /// 获取或设置“不满意”评价占比。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dissatisfied_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("dissatisfied_rate")]
                        public double DissatisfiedRate { get; set; }

                        /// <summary>
                        /// 获取或设置升级服务客户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_service_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_service_customer_cnt")]
                        public int UpgradeServiceCustomerCount { get; set; }

                        /// <summary>
                        /// 获取或设置专员服务邀请数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_service_member_invite_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_service_member_invite_cnt")]
                        public int UpgradeServiceMemberInviteCount { get; set; }

                        /// <summary>
                        /// 获取或设置添加专员的客户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_service_member_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_service_member_customer_cnt")]
                        public int UpgradeServiceMemberCustomerCount { get; set; }

                        /// <summary>
                        /// 获取或设置客户群服务邀请数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_service_groupchat_invite_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_service_groupchat_invite_cnt")]
                        public int UpgradeServiceGroupChatInviteCount { get; set; }

                        /// <summary>
                        /// 获取或设置加入客户群的客户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_service_groupchat_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_service_groupchat_customer_cnt")]
                        public int UpgradeServiceGroupChatCustomerCount { get; set; }

                        /// <summary>
                        /// 获取或设置被拒收消息的客户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_rejected_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_rejected_customer_cnt")]
                        public int MessageRejectedCustomerCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置统计日期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stat_date")]
                [System.Text.Json.Serialization.JsonPropertyName("stat_date")]
                public long StatisticsTimestamp { get; set; }

                /// <summary>
                /// 获取或设置统计数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("statistic")]
                [System.Text.Json.Serialization.JsonPropertyName("statistic")]
                public Types.Data Data { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置统计数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statistic_list")]
        [System.Text.Json.Serialization.JsonPropertyName("statistic_list")]
        public Types.Statistic[]? StatisticList { get; set; } = default!;
    }
}
