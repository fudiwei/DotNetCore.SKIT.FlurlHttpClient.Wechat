namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.ORDER_STATUS_FINANCE_SUCC 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#11 </para>
    /// </summary>
    public class OrderStatusFinanceSuccessEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderId")]
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderType")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderType")]
        [System.Xml.Serialization.XmlElement("OrderType")]
        public string OrderType { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status")]
        public string OrderStatus { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单生成时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateOrderTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateOrderTime")]
        [System.Xml.Serialization.XmlElement("CreateOrderTime")]
        public long OrderCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置订单支付成功时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PayFinishTime")]
        [System.Text.Json.Serialization.JsonPropertyName("PayFinishTime")]
        [System.Xml.Serialization.XmlElement("PayFinishTime")]
        public long OrderPayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置支付方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Desc")]
        [System.Text.Json.Serialization.JsonPropertyName("Desc")]
        [System.Xml.Serialization.XmlElement("Desc", IsNullable = true)]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置剩余免费券点数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FreeCoinCount")]
        [System.Text.Json.Serialization.JsonPropertyName("FreeCoinCount")]
        [System.Xml.Serialization.XmlElement("FreeCoinCount")]
        public int FreeCoinCount { get; set; }

        /// <summary>
        /// 获取或设置剩余付费券点数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PayCoinCount")]
        [System.Text.Json.Serialization.JsonPropertyName("PayCoinCount")]
        [System.Xml.Serialization.XmlElement("PayCoinCount")]
        public int PayCoinCount { get; set; }

        /// <summary>
        /// 获取或设置本次变动的免费券点数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RefundFreeCoinCount")]
        [System.Text.Json.Serialization.JsonPropertyName("RefundFreeCoinCount")]
        [System.Xml.Serialization.XmlElement("RefundFreeCoinCount")]
        public int RefundFreeCoinCount { get; set; }

        /// <summary>
        /// 获取或设置本次变动的付费券点数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RefundPayCoinCount")]
        [System.Text.Json.Serialization.JsonPropertyName("RefundPayCoinCount")]
        [System.Xml.Serialization.XmlElement("RefundPayCoinCount")]
        public int RefundPayCoinCount { get; set; }

        /// <summary>
        /// 获取或设置所开收据的详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ReceiptInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("ReceiptInfo")]
        [System.Xml.Serialization.XmlElement("ReceiptInfo", IsNullable = true)]
        public string? Receipt { get; set; }

        /// <summary>
        /// 获取或设置系统备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Memo")]
        [System.Text.Json.Serialization.JsonPropertyName("Memo")]
        [System.Xml.Serialization.XmlElement("Memo", IsNullable = true)]
        public string? Remark { get; set; }
    }
}
