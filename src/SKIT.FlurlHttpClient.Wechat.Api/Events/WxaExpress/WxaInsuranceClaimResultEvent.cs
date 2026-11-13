namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.wxainsurance_claim_result" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/event_push/express/business/claim_settlement_result.html ]]>
    /// </para>
    /// </summary>
    public class WxaInsuranceClaimResultEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OrderNo")]
                [System.Text.Json.Serialization.JsonPropertyName("OrderNo")]
                [System.Xml.Serialization.XmlElement("OrderNo")]
                public string? OrderNumber { get; set; }

                /// <summary>
                /// 获取或设置保单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Status")]
                [System.Text.Json.Serialization.JsonPropertyName("Status")]
                [System.Xml.Serialization.XmlElement("Status")]
                public string? Status { get; set; }

                /// <summary>
                /// 获取或设置理赔成功时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("FinishTime")]
                [System.Text.Json.Serialization.JsonPropertyName("FinishTime")]
                [System.Xml.Serialization.XmlElement("FinishTime", IsNullable = true)]
                public long? FinishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置理赔失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PayFailReason")]
                [System.Text.Json.Serialization.JsonPropertyName("PayFailReason")]
                [System.Xml.Serialization.XmlElement("PayFailReason", IsNullable = true)]
                public string? FailReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_event")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_event")]
        [System.Xml.Serialization.XmlElement("upload_event")]
        public Types.EventData? EventData { get; set; }
    }
}
