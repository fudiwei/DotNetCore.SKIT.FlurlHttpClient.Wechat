using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/get 接口的响应。</para>
    /// </summary>
    public class ProductOrderGetResponse : WechatApiResponse
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
                                    public class Attribute : ProductSKUGetResponse.Types.SKU.Types.Attribute
                                    { 
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_cnt")]
                                public int SKUCount { get; set; }

                                /// <summary>
                                /// 获取或设置正在售后流程中的 SKU 数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("on_aftersale_sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("on_aftersale_sku_cnt")]
                                public int OnAftersaleSKUCount { get; set; }

                                /// <summary>
                                /// 获取或设置已完成售后流程的 SKU 数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finish_aftersale_sku_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("finish_aftersale_sku_cnt")]
                                public int FinishAftersaleSKUCount { get; set; }

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
                                /// 获取或设置商品售价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sale_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                                public int SalePrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品属性列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_attrs")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                                public Types.Attribute[] AttributeList { get; set; } = default!;
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
                                /// 获取或设置预支付单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
                                public string PrepayId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置微信支付交易单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("transaction_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                                public string? TransactionId { get; set; }

                                /// <summary>
                                /// 获取或设置预支付时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("prepay_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("prepay_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonDateTimeOffsetConverter))]
                                public DateTimeOffset PrepayTime { get; set; }

                                /// <summary>
                                /// 获取或设置付款时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? PayTime { get; set; }
                            }

                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置商品金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                                public int ProductFee { get; set; }

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
                                /// 获取或设置是否有优惠（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_discounted")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_discounted")]
                                public bool IsDiscounted { get; set; }
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

                                    public class Address : ProductAddressGetResponse.Types.Address.Types.AddressDetail
                                    { 
                                    }

                                    public class ExpressFee
                                    {
                                        /// <summary>
                                        /// 获取或设置配送方式。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("shipping_method")]
                                        [System.Text.Json.Serialization.JsonPropertyName("shipping_method")]
                                        public string? ShippingMethod { get; set; }

                                        /// <summary>
                                        /// 获取或设置配送距离（单位：米）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("distance")]
                                        [System.Text.Json.Serialization.JsonPropertyName("distance")]
                                        public int Distance { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置快递方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_method")]
                                public string? DeliveryMethod { get; set; }

                                /// <summary>
                                /// 获取或设置发货时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? DeliveryTime { get; set; }

                                /// <summary>
                                /// 获取或设置快递详情信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_product_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_product_info")]
                                public Types.DeliveryDetail? DeliveryDetail { get; set; }

                                /// <summary>
                                /// 获取或设置快递地址信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                                public Types.Address? DeliveryAddress { get; set; }

                                /// <summary>
                                /// 获取或设置自提地址信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pickup_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("pickup_address")]
                                public Types.Address? PickupAddress { get; set; }

                                /// <summary>
                                /// 获取或设置配送费用列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("express_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("express_fee")]
                                public Types.ExpressFee[]? ExpressFeeList { get; set; }

                                /// <summary>
                                /// 获取或设置线下配送时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("offline_delivery_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("offline_delivery_time")]
                                public long? OfflineDeliveryTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置线下自提时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("offline_pickup_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("offline_pickup_time")]
                                public long? OfflinePickupTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置配送完成时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ship_done_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("ship_done_time")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long? ShippingDoneTimestamp { get; set; }
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
                                public long AftersaleOrderId { get; set; }
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

                    public class Extra
                    {
                        /// <summary>
                        /// 获取或设置顾客备注。
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
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义 ID。
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
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                public Types.Extra? Extra { get; set; }

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonDateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonDateTimeOffsetConverter))]
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
