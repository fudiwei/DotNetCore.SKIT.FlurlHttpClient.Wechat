namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.waybill_query_expect_time_range 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html ]]>
    /// </para>
    /// </summary>
    public class WaybillQueryExpectTimeRangeEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WXAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("WXAppId")]
        [System.Xml.Serialization.XmlElement("WXAppId")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置省份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Province")]
        [System.Text.Json.Serialization.JsonPropertyName("Province")]
        [System.Xml.Serialization.XmlElement("Province")]
        public string Province { get; set; } = default!;

        /// <summary>
        /// 获取或设置城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("City")]
        [System.Text.Json.Serialization.JsonPropertyName("City")]
        [System.Xml.Serialization.XmlElement("City")]
        public string City { get; set; } = default!;

        /// <summary>
        /// 获取或设置区县。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Area")]
        [System.Text.Json.Serialization.JsonPropertyName("Area")]
        [System.Xml.Serialization.XmlElement("Area")]
        public string District { get; set; } = default!;

        /// <summary>
        /// 获取或设置街道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Street")]
        [System.Text.Json.Serialization.JsonPropertyName("Street")]
        [System.Xml.Serialization.XmlElement("Street")]
        public string Street { get; set; } = default!;

        /// <summary>
        /// 获取或设置详细地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Address")]
        [System.Text.Json.Serialization.JsonPropertyName("Address")]
        [System.Xml.Serialization.XmlElement("Address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置地址 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Id")]
        [System.Text.Json.Serialization.JsonPropertyName("Id")]
        [System.Xml.Serialization.XmlElement("Id", IsNullable = true)]
        public string? AddressId { get; set; }
    }
}
