using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/add 接口的请求。</para>
    /// </summary>
    public class ShopOrderAddRequest : WechatApiRequest, IInferable<ShopOrderAddRequest, ShopOrderAddResponse>
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
                        /// 获取或设置商家自定义商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                        public string OutProductId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public string OutSKUId { get; set; } = string.Empty;

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
                        /// 获取或设置 SKU 总实付价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_real_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_real_price")]
                        public int SKURealPrice { get; set; }

                        /// <summary>
                        /// 获取或设置小程序商品页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string PagePath { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品头图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_img")]
                        public string HeadImageUrl { get; set; } = string.Empty;
                    }

                    public class Payment
                    {
                        /// <summary>
                        /// 获取或设置支付方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_method_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_method_type")]
                        public int PayType { get; set; }

                        /// <summary>
                        /// 获取或设置预支付单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prepay_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
                        public string PrepayId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置预支付时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prepay_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("prepay_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset PrepayTime { get; set; }
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
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();

                /// <summary>
                /// 获取或设置支付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_info")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_info")]
                public Types.Payment Payment { get; set; } = new Types.Payment();

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price_info")]
                [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                public Types.Amount Amount { get; set; } = new Types.Amount();
            }

            public class Delivery
            {
                /// <summary>
                /// 获取或设置快递方式。
                /// <para>默认值：1</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public int DeliveryType { get; set; } = 1;
            }

            public class Address : ShopAccountUpdateInfoRequest.Types.Address
            {
            }
        }

        /// <summary>
        /// 获取或设置商家自定义订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家自定义用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_user_id")]
        public string? OutUserId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

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
        public string PagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
        public Types.OrderDetail OrderDetail { get; set; } = new Types.OrderDetail();

        /// <summary>
        /// 获取或设置快递信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_detail")]
        public Types.Delivery Delivery { get; set; } = new Types.Delivery();

        /// <summary>
        /// 获取或设置地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_info")]
        [System.Text.Json.Serialization.JsonPropertyName("address_info")]
        public Types.Address? Address { get; set; }

        /// <summary>
        /// 获取或设置默认退货地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_receiving_address")]
        [System.Text.Json.Serialization.JsonPropertyName("default_receiving_address")]
        public Types.Address? DefaultReceivingAddress { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置超时时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.UnixTimestampDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.UnixTimestampDateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置确认收货之后多久禁止发起售后（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_duration")]
        public int? AftersaleDuration { get; set; }

        /// <summary>
        /// 获取或设置跟踪 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }
    }
}
