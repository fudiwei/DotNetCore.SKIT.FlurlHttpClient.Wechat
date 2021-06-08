using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/sku/add 接口的请求。</para>
    /// </summary>
    public class ProductSKUUpdatePriceRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置商品 ID。与字段 <see cref="OutProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义商品 ID。与字段 <see cref="ProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
        public string? OutProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。与字段 <see cref="OutSKUId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long? SKUId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义 SKU ID。与字段 <see cref="SKUId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
        public string? OutSKUId { get; set; }

        /// <summary>
        /// 获取或设置售价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_price")]
        [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
        public int SalePrice { get; set; }

        /// <summary>
        /// 获取或设置市场价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("market_price")]
        [System.Text.Json.Serialization.JsonPropertyName("market_price")]
        public int MarketPrice { get; set; }
    }
}
