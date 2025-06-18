using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/add 接口的请求。</para>
    /// </summary>
    public class ShopECAftersaleAddRequest : WechatApiRequest, IInferable<ShopECAftersaleAddRequest, ShopECAftersaleAddResponse>
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
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                public string? OutSKUId { get; set; }

                /// <summary>
                /// 获取或设置参与售后的商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                public int Count { get; set; }
            }

            public class Media
            {
                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置订单号。与字段 <see cref="OutOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义订单号。与字段 <see cref="OrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string? OutOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义售后单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
        public string? OutAftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置售后类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderamt")]
        [System.Text.Json.Serialization.JsonPropertyName("orderamt")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 获取或设置退款原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason_type")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason_type")]
        public int RefundReasonType { get; set; }

        /// <summary>
        /// 获取或设置退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_info")]
        [System.Text.Json.Serialization.JsonPropertyName("product_info")]
        public Types.Product Product { get; set; } = new Types.Product();

        /// <summary>
        /// 获取或设置附件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_list")]
        [System.Text.Json.Serialization.JsonPropertyName("media_list")]
        public IList<Types.Media>? MediaList { get; set; }
    }
}
