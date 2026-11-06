namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/add 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderAddRequest : CgibinExpressLocalBusinessRequestBase, IInferable<CgibinExpressLocalBusinessOrderAddRequest, CgibinExpressLocalBusinessOrderAddResponse>
    {
        public static class Types
        {
            public class Sender : CgibinExpressLocalBusinessOrderPreAddRequest.Types.Sender
            {
            }

            public class Receiver : Sender
            {
            }

            public class Cargo : CgibinExpressLocalBusinessOrderPreAddRequest.Types.__zz__Cargo
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        public static class Types
                        {
                            public class Goods : CgibinExpressLocalBusinessOrderPreAddRequest.Types.Cargo.Types.GoodsDetail.Types.Goods
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置货物列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                        public List<Types.Goods>? GoodsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置货物详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public Types.GoodsDetail? GoodsDetail { get; set; }
            }

            public class Order : CgibinExpressLocalBusinessOrderPreAddRequest.Types.Order
            {
            }

            public class Shop : CgibinExpressLocalBusinessOrderPreAddRequest.Types.Shop
            {
            }
        }

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        public string? ShopNumber { get; set; }

        /// <summary>
        /// 获取或设置配送公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string? DeliveryId { get; set; }

        /// <summary>
        /// 获取或设置预下单接口返回的参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_token")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_token")]
        public string? DeliveryToken { get; set; }

        /// <summary>
        /// 获取或设置下单用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender")]
        [System.Text.Json.Serialization.JsonPropertyName("sender")]
        public Types.Sender? Sender { get; set; }

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver")]
        public Types.Receiver? Receiver { get; set; }

        /// <summary>
        /// 获取或设置货物信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public Types.Cargo? Cargo { get; set; }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.Order? Order { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop")]
        [System.Text.Json.Serialization.JsonPropertyName("shop")]
        public Types.Shop? Shop { get; set; }

        /// <summary>
        /// 获取或设置子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_biz_id")]
        public string? SubBusinessId { get; set; }
    }
}
