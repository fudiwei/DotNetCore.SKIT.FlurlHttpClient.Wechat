namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.waybill_complaint 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html ]]>
    /// </para>
    /// </summary>
    public class WaybillComplaintEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Token")]
        [System.Text.Json.Serialization.JsonPropertyName("Token")]
        [System.Xml.Serialization.XmlElement("Token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WXAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("WXAppId")]
        [System.Xml.Serialization.XmlElement("WXAppId")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderID")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderID")]
        [System.Xml.Serialization.XmlElement("OrderID", IsNullable = true)]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillID")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillID")]
        [System.Xml.Serialization.XmlElement("WayBillID", IsNullable = true)]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置投诉类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ComplainType")]
        [System.Text.Json.Serialization.JsonPropertyName("ComplainType")]
        [System.Xml.Serialization.XmlElement("ComplainType")]
        public int ComplaintType { get; set; }

        /// <summary>
        /// 获取或设置投诉内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Content")]
        [System.Text.Json.Serialization.JsonPropertyName("Content")]
        [System.Xml.Serialization.XmlElement("Content")]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 获取或设置投诉材料图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Pic")]
        [System.Text.Json.Serialization.JsonPropertyName("Pic")]
        [System.Xml.Serialization.XmlElement("Pic", IsNullable = true)]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// 获取或设置联系人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Name")]
        [System.Text.Json.Serialization.JsonPropertyName("Name")]
        [System.Xml.Serialization.XmlElement("Name", IsNullable = true)]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置联系人电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Phone")]
        [System.Text.Json.Serialization.JsonPropertyName("Phone")]
        [System.Xml.Serialization.XmlElement("Phone", IsNullable = true)]
        public string? PhoneNumber { get; set; }
    }
}
