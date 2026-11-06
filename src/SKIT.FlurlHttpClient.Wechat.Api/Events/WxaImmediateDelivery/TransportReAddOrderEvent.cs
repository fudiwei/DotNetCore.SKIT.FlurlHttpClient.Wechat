namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.transport_readd_order" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onOrderReAdd.html ]]>
    /// </para>
    /// </summary>
    public class TransportReAddOrderEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Sender : TransportPreCreateOrderEvent.Types.Sender
            {
            }

            public class Receiver : Sender
            {
            }

            public class Cargo : TransportPreCreateOrderEvent.Types.__zz__Cargo
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        public static class Types
                        {
                            public class Goods : TransportPreCreateOrderEvent.Types.Cargo.Types.GoodsDetail.Types.Goods
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置货物列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                        [System.Xml.Serialization.XmlElement("goods", Type = typeof(Types.Goods))]
                        public List<Types.Goods>? GoodsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置货物详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                [System.Xml.Serialization.XmlElement("goods_detail")]
                public Types.GoodsDetail? GoodsDetail { get; set; }
            }

            public class Order : TransportPreCreateOrderEvent.Types.Order
            {
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        [System.Xml.Serialization.XmlElement("shopid")]
        public string? ShopId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        [System.Xml.Serialization.XmlElement("shop_order_id")]
        public string? ShopOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        [System.Xml.Serialization.XmlElement("shop_no")]
        public string? ShopNumber { get; set; }

        /// <summary>
        /// 获取或设置校验串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_sign")]
        [System.Xml.Serialization.XmlElement("delivery_sign")]
        public string? DeliverySignature { get; set; }

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
        public Types.Receiver? Receiver { get; set; }

        /// <summary>
        /// 获取或设置货物信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        [System.Xml.Serialization.XmlElement("cargo")]
        public Types.Cargo? Cargo { get; set; }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        [System.Xml.Serialization.XmlElement("order_info")]
        public Types.Order? Order { get; set; }

        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_token")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_token")]
        [System.Xml.Serialization.XmlElement("wx_token")]
        public string? WxToken { get; set; }
    }
}
