using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/add 接口的请求。</para>
    /// </summary>
    public class ProductSPUAddRequest : WechatApiRequest, IInferable<ProductSPUAddRequest, ProductSPUAddResponse>
    {
        public static class Types
        {
            public class Detail
            {
                /// <summary>
                /// 获取或设置商品详情图片 Url 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("imgs")]
                [System.Text.Json.Serialization.JsonPropertyName("imgs")]
                public IList<string> ImageUrlList { get; set; } = new List<string>();
            }

            public class Category
            {
                /// <summary>
                /// 获取或设置商品类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置商品类目层级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int Level { get; set; }
            }

            public class Attribute
            {
                /// <summary>
                /// 获取或设置属性的 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_key")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置属性的值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_value")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_value")]
                public string Value { get; set; } = string.Empty;
            }

            public class Express
            {
                /// <summary>
                /// 获取或设置运费模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public int TemplateId { get; set; }
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
        /// 获取或设置商品副标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_title")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
        public string? SubTitle { get; set; }

        /// <summary>
        /// 获取或设置主图 Url 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_img")]
        [System.Text.Json.Serialization.JsonPropertyName("head_img")]
        public IList<string> HeadImageUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc_info")]
        [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
        public Types.Detail Detail { get; set; } = new Types.Detail();

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public int BrandId { get; set; }

        /// <summary>
        /// 获取或设置商品类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cats")]
        [System.Text.Json.Serialization.JsonPropertyName("cats")]
        public IList<Types.Category> CategoryList { get; set; } = new List<Types.Category>();

        /// <summary>
        /// 获取或设置商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrs")]
        [System.Text.Json.Serialization.JsonPropertyName("attrs")]
        public IList<Types.Attribute> AttributeList { get; set; } = new List<Types.Attribute>();

        /// <summary>
        /// 获取或设置型号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model")]
        [System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 获取或设置运费信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_info")]
        [System.Text.Json.Serialization.JsonPropertyName("express_info")]
        public Types.Express? Express { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU>? SKUList { get; set; }
    }
}
