namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/get_order 接口的响应。</para>
    /// </summary>
    public class WxaSecOrderGetOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : WxaSecOrderGetOrderListResponse.Types.__zz__Order
            {
                public static class Types
                {
                    public class Shipping : WxaSecOrderGetOrderListResponse.Types.Order.Types.__zz__Shipping
                    {
                        public static class Types
                        {
                            public class Shipping : WxaSecOrderGetOrderListResponse.Types.Order.Types.Shipping.Types.__zz__Shipping
                            {
                                public static class Types
                                {
                                    public class Contact : WxaSecOrderGetOrderListResponse.Types.Order.Types.Shipping.Types.Shipping.Types.Contact
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置联系信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("contact")]
                                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                                public Types.Contact? Contact { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置物流信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_list")]
                        public List<Types.Shipping>? ShippingList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发货信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping")]
                public Types.Shipping? Shipping { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order? Order { get; set; }
    }
}
