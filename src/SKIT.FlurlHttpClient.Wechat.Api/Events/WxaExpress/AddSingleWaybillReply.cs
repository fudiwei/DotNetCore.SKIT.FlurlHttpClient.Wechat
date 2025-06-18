namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.add_single_waybill 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html ]]>
    /// </para>
    /// </summary>
    public class AddSingleWaybillReply : WechatApiEvent
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
        /// 获取或设置预计送达时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EstimatedDeliveryTime")]
        [System.Text.Json.Serialization.JsonPropertyName("EstimatedDeliveryTime")]
        [System.Xml.Serialization.XmlElement("EstimatedDeliveryTime", IsNullable = true)]
        public string? EstimatedDeliveryTimeString { get; set; }

        /// <summary>
        /// 获取或设置下单成功后跳转的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("JumpPath")]
        [System.Text.Json.Serialization.JsonPropertyName("JumpPath")]
        [System.Xml.Serialization.XmlElement("JumpPath", IsNullable = true)]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// 获取或设置取件码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PickCode")]
        [System.Text.Json.Serialization.JsonPropertyName("PickCode")]
        [System.Xml.Serialization.XmlElement("PickCode", IsNullable = true)]
        public string? PickCode { get; set; }

        public AddSingleWaybillReply()
        {
            MessageType = "event";
            Event = "add_single_waybill";
        }
    }
}
