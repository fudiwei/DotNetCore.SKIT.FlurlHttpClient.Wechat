namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.merchant_order 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/WeChat_Stores/WeChat_Store_Interface.html#8 ]]>
    /// </para>
    /// </summary>
    public class MerchantOrderEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderId")]
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderStatus")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderStatus")]
        [System.Xml.Serialization.XmlElement("OrderStatus")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ProductId")]
        [System.Text.Json.Serialization.JsonPropertyName("ProductId")]
        [System.Xml.Serialization.XmlElement("ProductId")]
        public string ProductId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 SKU 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SkuInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("SkuInfo")]
        [System.Xml.Serialization.XmlElement("SkuInfo")]
        public string SKUInformation { get; set; } = default!;
    }
}
