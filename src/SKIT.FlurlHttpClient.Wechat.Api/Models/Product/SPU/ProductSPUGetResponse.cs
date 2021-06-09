using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/get 接口的响应。</para>
    /// </summary>
    public class ProductSPUGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 SPU 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu")]
                [System.Text.Json.Serialization.JsonPropertyName("spu")]
                public SPU SPU { get; set; } = default!;
            }

            public class SPU
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
                        public string[] ImageUrlList { get; set; } = default!;
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

                    public class ShopCategory
                    {
                        /// <summary>
                        /// 获取或设置商品分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shopcat_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shopcat_id")]
                        public int CategoryId { get; set; }
                    }

                    public class Attribute
                    {
                        /// <summary>
                        /// 获取或设置属性的 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attr_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("attr_key")]
                        public string Key { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attr_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("attr_value")]
                        public string Value { get; set; } = default!;
                    }

                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }
                    }
                }

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
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

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
                public string[] HeadImageUrlList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc_info")]
                [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
                public Types.Detail Detail { get; set; } = default!;

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
                public Types.Category[] CategoryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopcat")]
                [System.Text.Json.Serialization.JsonPropertyName("shopcat")]
                public Types.ShopCategory[] ShopCategoryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("attrs")]
                public Types.Attribute[] AttributeList { get; set; } = default!;

                /// <summary>
                /// 获取或设置型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model")]
                [System.Text.Json.Serialization.JsonPropertyName("model")]
                public string? Model { get; set; }

                /// <summary>
                /// 获取或设置商品上线状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int ListingStatus { get; set; }

                /// <summary>
                /// 获取或设置商品草稿状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("edit_status")]
                public int EditingStatus { get; set; }

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? PagePath { get; set; }

                /// <summary>
                /// 获取或设置 SKU 最低价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("min_price")]
                [System.Text.Json.Serialization.JsonPropertyName("min_price")]
                public int MinPrice { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[]? SKUList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
