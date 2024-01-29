namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.xpay_goods_deliver_notify 事件的数据。</para>
    /// <para>https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html </para>
    /// </summary>
    public class XPayGoodsDeliverNotifyEvent : WechatApiEvent
    {
        public static class Types
        {
            public class WechatpayInfo
            {
                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MchOrderNo")]
                [System.Text.Json.Serialization.JsonPropertyName("MchOrderNo")]
                [System.Xml.Serialization.XmlElement("MchOrderNo")]
                public string MerchantOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TransactionId")]
                [System.Text.Json.Serialization.JsonPropertyName("TransactionId")]
                [System.Xml.Serialization.XmlElement("TransactionId")]
                public string TransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PaidTime")]
                [System.Text.Json.Serialization.JsonPropertyName("PaidTime")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("PaidTime")]
                public long PayTimestamp { get; set; }
            }

            public class GoodsInfo
            {
                /// <summary>
                /// 获取或设置道具 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ProductId")]
                [System.Text.Json.Serialization.JsonPropertyName("ProductId")]
                [System.Xml.Serialization.XmlElement("ProductId")]
                public string ProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("Quantity")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("Quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置原始价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OrigPrice")]
                [System.Text.Json.Serialization.JsonPropertyName("OrigPrice")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("OrigPrice")]
                public int OriginalPrice { get; set; }

                /// <summary>
                /// 获取或设置实付价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ActualPrice")]
                [System.Text.Json.Serialization.JsonPropertyName("ActualPrice")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("ActualPrice")]
                public int ActualPrice { get; set; }

                /// <summary>
                /// 获取或设置透传信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Attach")]
                [System.Text.Json.Serialization.JsonPropertyName("Attach")]
                [System.Xml.Serialization.XmlElement("Attach", IsNullable = true)]
                public string? Attachment { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenId")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenId")]
        [System.Xml.Serialization.XmlElement("OpenId")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置业务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OutTradeNo")]
        [System.Text.Json.Serialization.JsonPropertyName("OutTradeNo")]
        [System.Xml.Serialization.XmlElement("OutTradeNo")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置虚拟支付环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Env")]
        [System.Text.Json.Serialization.JsonPropertyName("Env")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlElement("Env")]
        public int Environment { get; set; }

        /// <summary>
        /// 获取或设置微信支付信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WeChatPayInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("WeChatPayInfo")]
        [System.Xml.Serialization.XmlElement("WeChatPayInfo", IsNullable = true)]
        public Types.WechatpayInfo? WechatpayInfo { get; set; }

        /// <summary>
        /// 获取或设置道具信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("GoodsInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("GoodsInfo")]
        [System.Xml.Serialization.XmlElement("GoodsInfo", IsNullable = true)]
        public Types.GoodsInfo? GoodsInfo { get; set; }
    }
}
