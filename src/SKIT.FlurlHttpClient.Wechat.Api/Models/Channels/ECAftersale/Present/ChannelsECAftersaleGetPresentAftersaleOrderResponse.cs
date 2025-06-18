namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getpresentaftersaleorder 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleGetPresentAftersaleOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AftersaleOrder
            {
                public static class Types
                {
                    public class Order
                    {
                        public static class Types
                        {
                            public class Product
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("count")]
                                [System.Text.Json.Serialization.JsonPropertyName("count")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置退款信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_info")]
                                public Refund? Refund { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_info")]
                        public Refund? Refund { get; set; }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_info_list")]
                        public Types.Product[] ProductList { get; set; } = default!;
                    }

                    public class Refund : ChannelsECAftersaleGetAftersaleOrderResponse.Types.AftersaleOrder.Types.Refund
                    {
                    }
                }

                /// <summary>
                /// 获取或设置售后单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string AftersaleOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置礼物订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PresentOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置买家用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置买家用户 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置订单信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_info_list")]
                public Types.Order[] OrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_info")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_info")]
                public Types.Refund? Refund { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置售后单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order")]
        public Types.AftersaleOrder AftersaleOrder { get; set; } = default!;
    }
}
