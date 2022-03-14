namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/get_corp_statistic 接口的响应。</para>
    /// </summary>
    public class CgibinKfGetCorpStatisticResponse : WechatWorkResponse
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
                        /// 获取或设置升级服务客户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upgrade_service_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("upgrade_service_customer_cnt")]
                        public int UpgradeServiceCustomerCount { get; set; }

                        /// <summary>
                        /// 获取或设置智能回复会话数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ai_session_reply_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("ai_session_reply_cnt")]
                        public int AISessionReplyCount { get; set; }

                        /// <summary>
                        /// 获取或设置智能回复转人工率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ai_transfer_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("ai_transfer_rate")]
                        public double AITransferRate { get; set; }

                        /// <summary>
                        /// 获取或设置智能回复知识命中率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ai_knowledge_hit_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("ai_knowledge_hit_rate")]
                        public double AIKnowledgeHitRate { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置统计日期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stat_time")]
                [System.Text.Json.Serialization.JsonPropertyName("stat_time")]
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
