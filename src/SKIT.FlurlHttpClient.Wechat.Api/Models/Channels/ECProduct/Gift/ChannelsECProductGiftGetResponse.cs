using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/gift/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductGiftGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Detail : ChannelsECProductGetResponse.Types.Product.Types.Detail
                    {
                    }

                    public class Category : ChannelsECProductGetResponse.Types.Product.Types.Category
                    {
                    }

                    public class Attribute : ChannelsECProductGetResponse.Types.Product.Types.Attribute
                    {
                    }

                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
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
                        /// 获取或设置 SKU 状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置赠品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义赠品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置主图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_imgs")]
                [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
                public string[] HeadImageUrlList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc_info")]
                [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
                public Types.Detail Detail { get; set; } = default!;

                /// <summary>
                /// 获取或设置新版商品类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cats_v2")]
                [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                public Types.Category[]? CategoryV2List { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("attrs")]
                public Types.Attribute[]? AttributeList { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_code")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_code")]
                public string? SPUCode { get; set; }

                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? BrandId { get; set; }

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置商品草稿状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("edit_status")]
                public int EditingStatus { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[]? SKUList { get; set; }

                /// <summary>
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int? ProductType { get; set; }

                /// <summary>
                /// 获取或设置商品草稿最近一次修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("edit_time")]
                public long EditTimestamp { get; set; }

                /// <summary>
                /// 获取或设置导入的来源商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("src_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("src_product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? SourceProductId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置线上赠品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product? Product { get; set; }

        /// <summary>
        /// 获取或设置草稿赠品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edit_product")]
        [System.Text.Json.Serialization.JsonPropertyName("edit_product")]
        public Types.Product? EditingProduct { get; set; }
    }
}
