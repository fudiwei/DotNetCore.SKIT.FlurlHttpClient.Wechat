namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.xpay_subscribe_pay_fail_notify 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/vips.html ]]>
    /// </para>
    /// </summary>
    public class XPaySubscribePayFailEvent : WechatApiEvent
    {
        public static class Types
        {
            public class WechatpayInfo : XPayGoodsDeliverNotifyEvent.Types.WechatpayInfo
            {
            }

            public class GoodsInfo : XPayGoodsDeliverNotifyEvent.Types.GoodsInfo
            {
                /// <summary>
                /// 获取或设置订阅周期（单位：天）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("SubscribePeriodDays")]
                [System.Text.Json.Serialization.JsonPropertyName("SubscribePeriodDays")]
                [System.Xml.Serialization.XmlElement("SubscribePeriodDays", IsNullable = true)]
                public int? SubscribePeriodDays { get; set; }
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
        /// 获取或设置签约所属微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ContractWxAppid")]
        [System.Text.Json.Serialization.JsonPropertyName("ContractWxAppid")]
        [System.Xml.Serialization.XmlElement("ContractWxAppid", IsNullable = true)]
        public string? ContractAppId { get; set; }
    }
}
