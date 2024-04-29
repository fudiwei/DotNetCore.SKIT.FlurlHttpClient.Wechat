namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_task_award 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/callback/member/user_finish_task.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECVipTaskAwardEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Task
            {
                public static class Types
                {
                    public class AwardInfo
                    {
                        /// <summary>
                        /// 获取或设置奖励类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("award_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("award_type")]
                        [System.Xml.Serialization.XmlElement("award_type")]
                        public int AwardType { get; set; }

                        /// <summary>
                        /// 获取或设置奖励的优惠券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        [System.Xml.Serialization.XmlElement("coupon_id", IsNullable = true)]
                        public long? CouponId { get; set; }

                        /// <summary>
                        /// 获取或设置奖励的积分。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gain_score")]
                        [System.Text.Json.Serialization.JsonPropertyName("gain_score")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        [System.Xml.Serialization.XmlElement("gain_score", IsNullable = true)]
                        public int? GainScore { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                [System.Xml.Serialization.XmlElement("task_id")]
                public long TaskId { get; set; }

                /// <summary>
                /// 获取或设置任务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_name")]
                [System.Text.Json.Serialization.JsonPropertyName("task_name")]
                [System.Xml.Serialization.XmlElement("task_name")]
                public string TaskName { get; set; } = default!;

                /// <summary>
                /// 获取或设置奖励信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_info")]
                [System.Text.Json.Serialization.JsonPropertyName("award_info")]
                [System.Xml.Serialization.XmlElement("award_info")]
                public Types.AwardInfo AwardInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置任务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_info")]
        [System.Text.Json.Serialization.JsonPropertyName("task_info")]
        [System.Xml.Serialization.XmlElement("task_info")]
        public Types.Task Task { get; set; } = default!;
    }
}
