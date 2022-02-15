using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/spu/add 接口的请求。</para>
    /// </summary>
    public class ShopSPUAddRequest : WechatApiRequest, IMapResponse<ShopSPUAddRequest, ShopSPUAddResponse>
    {
        public static class Types
        {
            public class Detail : ProductSPUAddRequest.Types.Detail
            {
                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Description { get; set; } = string.Empty;
            }

            public class Attribute : ProductSPUAddRequest.Types.Attribute
            {
            }

            public class SKU
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
                public IList<Attribute> AttributeList { get; set; } = new List<Attribute>();
            }
        }

        /// <summary>
        /// 获取或设置商家自定义商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
        public string OutProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序商品页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string PagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主图 Url 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_img")]
        [System.Text.Json.Serialization.JsonPropertyName("head_img")]
        public IList<string> HeadImageUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品资质图片 Url 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_pics")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_pics")]
        public IList<string>? QualificationPictureUrlList { get; set; }

        /// <summary>
        /// 获取或设置商品详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc_info")]
        [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
        public Types.Detail? Detail { get; set; }

        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("third_cat_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public int BrandId { get; set; }

        /// <summary>
        /// 获取或设置版本控制。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_version")]
        [System.Text.Json.Serialization.JsonPropertyName("info_version")]
        public string? InfoVersion { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
