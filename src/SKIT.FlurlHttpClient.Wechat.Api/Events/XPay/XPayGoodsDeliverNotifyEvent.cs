namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.xpay_goods_deliver_notify 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/virtual-payment.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/vips.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/vip.html ]]>
    /// </para>
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

            public class TeamInfo
            {
                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ActivityId")]
                [System.Text.Json.Serialization.JsonPropertyName("ActivityId")]
                [System.Xml.Serialization.XmlElement("ActivityId")]
                public string ActivityId { get; set; } = default!;

                /// <summary>
                /// 获取或设置拼团 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TeamId")]
                [System.Text.Json.Serialization.JsonPropertyName("TeamId")]
                [System.Xml.Serialization.XmlElement("TeamId")]
                public string TeamId { get; set; } = default!;

                /// <summary>
                /// 获取或设置拼团类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TeamType")]
                [System.Text.Json.Serialization.JsonPropertyName("TeamType")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("TeamType")]
                public int TeamType { get; set; }

                /// <summary>
                /// 获取或设置拼团操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TeamAction")]
                [System.Text.Json.Serialization.JsonPropertyName("TeamAction")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("TeamAction")]
                public int TeamAction { get; set; }
            }

            public class AppleSubscriptionInfo
            {
                /// <summary>
                /// 获取或设置苹果原始交易 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OriginalTransactionId")]
                [System.Text.Json.Serialization.JsonPropertyName("OriginalTransactionId")]
                [System.Xml.Serialization.XmlElement("OriginalTransactionId")]
                public string OriginalTransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置自动续费状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("AutoRenewStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("AutoRenewStatus")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("AutoRenewStatus")]
                public int AutoRenewStatus { get; set; }

                /// <summary>
                /// 获取或设置订阅下次续费时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("RenewalDate")]
                [System.Text.Json.Serialization.JsonPropertyName("RenewalDate")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("RenewalDate")]
                public long RenewalTimestamp { get; set; }
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

        /// <summary>
        /// 获取或设置拼团信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TeamInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("TeamInfo")]
        [System.Xml.Serialization.XmlElement("TeamInfo", IsNullable = true)]
        public Types.TeamInfo? TeamInfo { get; set; }

        /// <summary>
        /// 获取或设置苹果订阅签约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppleSubscriptionInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("AppleSubscriptionInfo")]
        [System.Xml.Serialization.XmlElement("AppleSubscriptionInfo", IsNullable = true)]
        public Types.AppleSubscriptionInfo? AppleSubscriptionInfo { get; set; }
    }
}
