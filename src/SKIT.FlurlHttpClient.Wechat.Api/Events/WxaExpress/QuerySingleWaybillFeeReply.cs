namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.query_single_waybill_fee 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html </para>
    /// </summary>
    public class QuerySingleWaybillFeeReply : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
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
        /// 获取或设置预估运费（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Fee")]
        [System.Text.Json.Serialization.JsonPropertyName("Fee")]
        [System.Xml.Serialization.XmlElement("Fee")]
        public double Fee { get; set; }

        /// <summary>
        /// 获取或设置预估原价（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OriginalFee")]
        [System.Text.Json.Serialization.JsonPropertyName("OriginalFee")]
        [System.Xml.Serialization.XmlElement("OriginalFee", IsNullable = true)]
        public double? OriginalFee { get; set; }

        public QuerySingleWaybillFeeReply()
        {
            MessageType = "event";
            Event = "query_single_waybill_fee";
        }
    }
}
