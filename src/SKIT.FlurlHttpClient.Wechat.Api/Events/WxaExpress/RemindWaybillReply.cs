namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.remind_waybill 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html </para>
    /// </summary>
    public class RemindWaybillReply : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
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
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillID")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillID")]
        [System.Xml.Serialization.XmlElement("WayBillID", IsNullable = true)]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置预计寄送时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EstimatedDeliveryTime")]
        [System.Text.Json.Serialization.JsonPropertyName("EstimatedDeliveryTime")]
        [System.Xml.Serialization.XmlElement("EstimatedDeliveryTime", IsNullable = true)]
        public string? EstimatedDeliveryTimeString { get; set; }

        public RemindWaybillReply()
        {
            MessageType = "event";
            Event = "remind_waybill";
        }
    }
}
