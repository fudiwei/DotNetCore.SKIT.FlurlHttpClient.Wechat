using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/get 接口的响应。</para>
    /// </summary>
    public class ShopOrderGetResponse : WechatApiResponse
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
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商家自定义商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                                public string OutProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置商家自定义 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                                public string OutSKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置商品售价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sale_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                                public int SalePrice { get; set; }

                                /// <summary>
                                /// 获取或设置均摊价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("real_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("real_price")]
                                public int RealPrice { get; set; }

                                /// <summary>
                                /// 获取或设置小程序商品页面标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置小程序商品页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path")]
                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                public string PagePath { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品头图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("head_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("head_img")]
                                public string HeadImageUrl { get; set; } = default!;
                            }

                            public class Payment
                            {
                                /// <summary>
                                /// 获取或设置支付方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_method")]
                                public string PayMethod { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置支付方式类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_method_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_method_type")]
                                public int PayMethodType { get; set; }

                                /// <summary>
                                /// 获取或设置预支付单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
                                public string PrepayId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置预支付时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                                public DateTimeOffset PrepayTime { get; set; }

                                /// <summary>
                                /// 获取或设置支付交易单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("transaction_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                                public string? TransactionId { get; set; }

                                /// <summary>
                                /// 获取或设置付款时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? PayTime { get; set; }
                            }

                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置订单金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_price")]
                                public int OrderFee { get; set; }

                                /// <summary>
                                /// 获取或设置运费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("freight")]
                                [System.Text.Json.Serialization.JsonPropertyName("freight")]
                                public int FreightFee { get; set; }

                                /// <summary>
                                /// 获取或设置优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discounted_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("discounted_price")]
                                public int DiscountedFee { get; set; }

                                /// <summary>
                                /// 获取或设置附加金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("additional_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("additional_price")]
                                public int AdditionalPrice { get; set; }

                                /// <summary>
                                /// 获取或设置附加金额备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("additional_remarks")]
                                [System.Text.Json.Serialization.JsonPropertyName("additional_remarks")]
                                public string? AdditionalRemark { get; set; }
                            }

                            public class Delivery
                            {
                                public static class Types
                                {
                                    public class DeliveryDetail
                                    {
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
                                    }
                                }

                                /// <summary>
                                /// 获取或设置快递方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                                public int DeliveryType { get; set; }

                                /// <summary>
                                /// 获取或设置是否发货完成。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finish_all_delivery")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("finish_all_delivery")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                                public bool IsFinishAll { get; set; }

                                /// <summary>
                                /// 获取或设置快递详情列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_list")]
                                public Types.DeliveryDetail[]? DeliveryDetailList { get; set; }
                            }

                            public class Promotion
                            {
                                /// <summary>
                                /// 获取或设置推广员 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promoter_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
                                public string? PromoterId { get; set; }

                                /// <summary>
                                /// 获取或设置推广员 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promoter_openid")]
                                [System.Text.Json.Serialization.JsonPropertyName("promoter_openid")]
                                public string? PromoterOpenId { get; set; }

                                /// <summary>
                                /// 获取或设置推广员昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_nickname")]
                                public string? FinderNickname { get; set; }

                                /// <summary>
                                /// 获取或设置分享者的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sharer_openid")]
                                [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
                                public string? SharerOpenId { get; set; }

                                /// <summary>
                                /// 获取或设置直播开始时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("live_start_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("live_start_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? LiveStartTime { get; set; }
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
                        public Types.Payment? Payment { get; set; }

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_detail")]
                        public Types.Delivery? Delivery { get; set; }

                        /// <summary>
                        /// 获取或设置推广信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_info")]
                        public Types.Promotion? Promotion { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
                public string OutOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fund_type")]
                [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
                public int FundType { get; set; }

                /// <summary>
                /// 获取或设置场景值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene")]
                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                public int Scene { get; set; }

                /// <summary>
                /// 获取或设置小程序订单页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
                public Types.OrderDetail OrderDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
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
