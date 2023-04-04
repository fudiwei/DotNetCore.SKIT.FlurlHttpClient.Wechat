namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class OrderDetail
                    {
                        public static class Types
                        {
                            public class Product
                            {
                                public static class Types
                                {
                                    public class Attribute : ChannelsECProductGetResponse.Types.Product.Types.Attribute
                                    {
                                    }
                                }

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
                                [Newtonsoft.Json.JsonProperty("sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_cnt")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置正在售后流程中的商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("on_aftersale_sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("on_aftersale_sku_cnt")]
                                public int OnAftersaleCount { get; set; }

                                /// <summary>
                                /// 获取或设置已完成售后流程的商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finish_aftersale_sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("finish_aftersale_sku_cnt")]
                                public int FinishAftersaleCount { get; set; }

                                /// <summary>
                                /// 获取或设置商品标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                                public string ThumbnailImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品原价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("market_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                                public int MarketPrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品售价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sale_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                                public int SalePrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品实付价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("real_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("real_price")]
                                public int? RealPrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品属性列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_attrs")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                                public Types.Attribute[]? AttributeList { get; set; }
                            }

                            public class Payment
                            {
                                /// <summary>
                                /// 获取或设置预支付单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
                                public string PrepayId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置预支付时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_time")]
                                public long PrepayTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置微信支付交易单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("transaction_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                                public string? TransactionId { get; set; }

                                /// <summary>
                                /// 获取或设置付款时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                                public long? PayTimestamp { get; set; }
                            }

                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置商品金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                                public int ProductPrice { get; set; }

                                /// <summary>
                                /// 获取或设置订单金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_price")]
                                public int OrderPrice { get; set; }

                                /// <summary>
                                /// 获取或设置运费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("freight")]
                                public int FreightPrice { get; set; }

                                /// <summary>
                                /// 获取或设置优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discounted_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("discounted_price")]
                                public int DiscountedPrice { get; set; }

                                /// <summary>
                                /// 获取或设置是否有优惠。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_discounted")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_discounted")]
                                public bool IsDiscounted { get; set; }

                                /// <summary>
                                /// 获取或设置订单原始价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_order_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_order_price")]
                                public int? OriginalOrderPrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品预估价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("estimate_product_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("estimate_product_price")]
                                public int? EstimatedProductPrice { get; set; }

                                /// <summary>
                                /// 获取或设置改价后降低金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("change_down_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("change_down_price")]
                                public int? ChangedDownPrice { get; set; }

                                /// <summary>
                                /// 获取或设置改价后运费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("change_freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("change_freight")]
                                public int? ChangedFreightPrice { get; set; }

                                /// <summary>
                                /// 获取或设置是否修改运费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_change_freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_change_freight")]
                                public bool? IsFreightChanged { get; set; }
                            }

                            public class Delivery
                            {
                                public static class Types
                                {
                                    public class DeliveryProduct
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
                                                [Newtonsoft.Json.JsonProperty("product_cnt")]
                                                [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                                                public int Count { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置快递方式。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("deliver_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("deliver_type")]
                                        public int DeliverType { get; set; }

                                        /// <summary>
                                        /// 获取或设置快递公司 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                                        public string DeliveryId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置快递单号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("waybill_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                                        public string WaybillId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置发货时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("delivery_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                                        public long DeliveryTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_infos")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                                        public Types.Product[] ProductList { get; set; } = default!;
                                    }

                                    public class Address : ChannelsECMerchantAddressGetResponse.Types.AddressDetail.Types.Address
                                    {
                                        /// <summary>
                                        /// 获取或设置虚拟发货订单电话号码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("virtual_order_tel_number")]
                                        [System.Text.Json.Serialization.JsonPropertyName("virtual_order_tel_number")]
                                        public string? VirtualOrderTeleNumber { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置发货方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("deliver_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("deliver_method")]
                                public int DeliverMethod { get; set; }

                                /// <summary>
                                /// 获取或设置地址信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                                public Types.Address? Address { get; set; }

                                /// <summary>
                                /// 获取或设置发货商品信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_product_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_product_info")]
                                public Types.DeliveryProduct[] DeliveryProductList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置配送完成时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ship_done_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("ship_done_time")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long? ShippingDoneTimestamp { get; set; }
                            }

                            public class Coupon
                            {
                                /// <summary>
                                /// 获取或设置用户优惠券 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_coupon_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_coupon_id")]
                                public string? UserCouponId { get; set; }
                            }

                            public class Extra
                            {
                                /// <summary>
                                /// 获取或设置用户备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_notes")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_notes")]
                                public string? CustomerNotes { get; set; }

                                /// <summary>
                                /// 获取或设置商家备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_notes")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_notes")]
                                public string? MerchantNotes { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                        public Types.Product[] ProductList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_info")]
                        public Types.Payment Payment { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
                        public Types.Delivery? Delivery { get; set; }

                        /// <summary>
                        /// 获取或设置优惠券信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                        public Types.Coupon? Coupon { get; set; }

                        /// <summary>
                        /// 获取或设置扩展信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                        public Types.Extra? Extra { get; set; }
                    }

                    public class AftersaleDetail
                    {
                        public static class Types
                        {
                            public class AftersaleOrder
                            {
                                /// <summary>
                                /// 获取或设置售后单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_order_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string AftersaleOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置售后单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_order_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_order_list")]
                        public Types.AftersaleOrder[] AftersaleOrderList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置正在售后流程中的售后单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("on_aftersale_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("on_aftersale_order_cnt")]
                        public int OnAftersaleOrderCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置订单详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
                public Types.OrderDetail OrderDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_detail")]
                public Types.AftersaleDetail? AftersaleDetail { get; set; }

                /// <summary>
                /// 获取或设置下单用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

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
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
