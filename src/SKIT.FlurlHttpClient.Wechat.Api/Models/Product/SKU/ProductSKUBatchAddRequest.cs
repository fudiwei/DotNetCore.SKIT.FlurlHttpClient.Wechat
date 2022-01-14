using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/sku/batch_add 接口的请求。</para>
    /// </summary>
    public class ProductSKUBatchAddRequest : WechatApiRequest
    {
        public static class Types
        {
            public class SKU
            {
                public static class Types
                {
                    public class Attribute : ProductSPUAddRequest.Types.Attribute
                    {
                    }
                }

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
                /// 获取或设置商家自定义 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                public string OutSKUId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置缩略图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_img")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                public string ThumbnailUrl { get; set; } = string.Empty;

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

                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                public int Stock { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_code")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                public string? SKUCode { get; set; }

                /// <summary>
                /// 获取或设置条形码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("barcode")]
                [System.Text.Json.Serialization.JsonPropertyName("barcode")]
                public string? BarCode { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                public IList<Types.Attribute> AttributeList { get; set; } = new List<Types.Attribute>();
            }
        }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
