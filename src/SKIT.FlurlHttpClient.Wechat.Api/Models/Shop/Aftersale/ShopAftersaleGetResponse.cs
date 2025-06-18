using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/aftersale/get 接口的响应。</para>
    /// </summary>
    public class ShopAftersaleGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AftersaleOrder
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
                        public string OutProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public string OutSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置参与售后的商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                        public int? Count { get; set; }
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
                /// 获取或设置商家自定义售后单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
                public string OutAftersaleOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序该售后单的页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置售后状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund")]
                [System.Text.Json.Serialization.JsonPropertyName("refund")]
                public int RefundFee { get; set; }

                /// <summary>
                /// 获取或设置发起申请时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                public Types.Product[] ProductList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置售后单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_infos")]
        public Types.AftersaleOrder[] AftersaleOrderList { get; set; } = default!;
    }
}
