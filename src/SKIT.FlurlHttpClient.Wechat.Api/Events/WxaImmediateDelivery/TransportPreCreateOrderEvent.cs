namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.transport_precreate_order 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onOrderPreAdd.html </para>
    /// </summary>
    public class TransportPreCreateOrderEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Sender : Models.CgibinExpressLocalBusinessOrderAddRequest.Types.Sender
            {
            }

            public class Receiver : Models.CgibinExpressLocalBusinessOrderAddRequest.Types.Receiver
            {
            }

            public class Cargo : Models.CgibinExpressLocalBusinessOrderAddRequest.Types.Cargo
            {
            }

            public class Order : Models.CgibinExpressLocalBusinessOrderAddRequest.Types.Order
            {
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        [System.Xml.Serialization.XmlElement("shopid")]
        public string ShopId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        [System.Xml.Serialization.XmlElement("shop_order_id")]
        public string ShopOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        [System.Xml.Serialization.XmlElement("shop_no")]
        public string ShopNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置校验串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_sign")]
        [System.Xml.Serialization.XmlElement("delivery_sign")]
        public string DeliverySignature { get; set; } = default!;

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender")]
        [System.Text.Json.Serialization.JsonPropertyName("sender")]
        [System.Xml.Serialization.XmlElement("sender")]
        public Types.Sender? Sender { get; set; }

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver")]
        [System.Xml.Serialization.XmlElement("receiver")]
        public Types.Receiver Receiver { get; set; } = default!;

        /// <summary>
        /// 获取或设置货物信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        [System.Xml.Serialization.XmlElement("cargo")]
        public Types.Cargo Cargo { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        [System.Xml.Serialization.XmlElement("order_info")]
        public Types.Order Order { get; set; } = default!;
    }
}
