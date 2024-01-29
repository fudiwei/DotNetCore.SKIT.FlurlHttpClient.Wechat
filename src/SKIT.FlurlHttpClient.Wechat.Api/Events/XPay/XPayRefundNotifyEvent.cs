namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.xpay_refund_notify 事件的数据。</para>
    /// <para>https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/virtual-payment.html </para>
    /// </summary>
    public class XPayRefundNotifyEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenId")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenId")]
        [System.Xml.Serialization.XmlElement("OpenId")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MchRefundId")]
        [System.Text.Json.Serialization.JsonPropertyName("MchRefundId")]
        [System.Xml.Serialization.XmlElement("MchRefundId")]
        public string MerchantRefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WxRefundId")]
        [System.Text.Json.Serialization.JsonPropertyName("WxRefundId")]
        [System.Xml.Serialization.XmlElement("WxRefundId")]
        public string WechatpayRefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MchOrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("MchOrderId")]
        [System.Xml.Serialization.XmlElement("MchOrderId")]
        public string MerchantOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WxOrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("WxOrderId")]
        [System.Xml.Serialization.XmlElement("WxOrderId")]
        public string WechatpayOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款单的微信支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WxpayRefundTransactionId")]
        [System.Text.Json.Serialization.JsonPropertyName("WxpayRefundTransactionId")]
        [System.Xml.Serialization.XmlElement("WxpayRefundTransactionId", IsNullable = true)]
        public string? WechatpayRefundTransactionId { get; set; }

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RefundFee")]
        [System.Text.Json.Serialization.JsonPropertyName("RefundFee")]
        [System.Xml.Serialization.XmlElement("RefundFee")]
        public int RefundFee { get; set; }

        /// <summary>
        /// 获取或设置退款结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RetCode")]
        [System.Text.Json.Serialization.JsonPropertyName("RetCode")]
        [System.Xml.Serialization.XmlElement("RetCode")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置退款结果详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RetMsg")]
        [System.Text.Json.Serialization.JsonPropertyName("RetMsg")]
        [System.Xml.Serialization.XmlElement("RetMsg", IsNullable = true)]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置开始退款时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RefundStartTimestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("RefundStartTimestamp")]
        [System.Xml.Serialization.XmlElement("RefundStartTimestamp")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束退款时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RefundSuccTimestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("RefundSuccTimestamp")]
        [System.Xml.Serialization.XmlElement("RefundSuccTimestamp")]
        public long? SuccessTimestamp { get; set; }

        /// <summary>
        /// 获取或设置重试次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RetryTimes")]
        [System.Text.Json.Serialization.JsonPropertyName("RetryTimes")]
        [System.Xml.Serialization.XmlElement("RetryTimes")]
        public int RetryTimes { get; set; }
    }
}
