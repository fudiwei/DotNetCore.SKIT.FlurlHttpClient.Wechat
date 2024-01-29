namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.waybill_query_expect_time_range 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html </para>
    /// </summary>
    public class WaybillQueryExpectTimeRangeReply : WechatApiEvent
    {
        public static class Types
        {
            public class ValidTimeRange
            {
                /// <summary>
                /// 获取或设置开始时间小时数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("StartTime")]
                [System.Text.Json.Serialization.JsonPropertyName("StartTime")]
                [System.Xml.Serialization.XmlElement("StartTime")]
                public int StartTimeHours { get; set; }

                /// <summary>
                /// 获取或设置结束时间小时数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("EndTime")]
                [System.Text.Json.Serialization.JsonPropertyName("EndTime")]
                [System.Xml.Serialization.XmlElement("EndTime")]
                public int EndTimeHours { get; set; }

                /// <summary>
                /// 获取或设置天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("DayDelta")]
                [System.Text.Json.Serialization.JsonPropertyName("DayDelta")]
                [System.Xml.Serialization.XmlElement("DayDelta", IsNullable = true)]
                public int? DayDelta { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Status")]
                [System.Text.Json.Serialization.JsonPropertyName("Status")]
                [System.Xml.Serialization.XmlElement("Status", IsNullable = true)]
                public int? Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置处理结果错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultCode")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultCode")]
        [System.Xml.Serialization.XmlElement("ResultCode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置处理结果错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultMsg")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultMsg")]
        [System.Xml.Serialization.XmlElement("ResultMsg", IsNullable = true)]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// 获取或设置可预约时间段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ValidTimeRange")]
        [System.Text.Json.Serialization.JsonPropertyName("ValidTimeRange")]
        [System.Xml.Serialization.XmlElement("ValidTimeRange", Type = typeof(Types.ValidTimeRange))]
        public Types.ValidTimeRange[] ValidTimeRangeList { get; set; } = default!;

        public WaybillQueryExpectTimeRangeReply()
        {
            MessageType = "event";
            Event = "waybill_query_expect_time_range";
        }
    }
}
