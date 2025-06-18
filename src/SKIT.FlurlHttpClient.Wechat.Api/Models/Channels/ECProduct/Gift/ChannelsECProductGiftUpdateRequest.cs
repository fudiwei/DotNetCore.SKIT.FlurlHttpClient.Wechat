using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/gift/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductGiftUpdateRequest : WechatApiRequest, IInferable<ChannelsECProductGiftUpdateRequest, ChannelsECProductGiftUpdateResponse>
    {
        public static class Types
        {
            public class Detail : ChannelsECProductGiftAddRequest.Types.Detail
            {
            }

            public class Category : ChannelsECProductGiftAddRequest.Types.Category
            {
            }

            public class Attribute : ChannelsECProductGiftAddRequest.Types.Attribute
            {
            }

            public class SKU
            {
                public static class Types
                {
                    public class StockDiff
                    {
                        /// <summary>
                        /// 获取或设置修改类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("diff_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("diff_type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置修改数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num")]
                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long? SKUId { get; set; }

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
                public int? Stock { get; set; }

                /// <summary>
                /// 获取或设置库存变更信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_diff")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_diff")]
                public Types.StockDiff? StockDiff { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_code")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                public string? SKUCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置赠品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置赠品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_imgs")]
        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
        public IList<string> HeadImageUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc_info")]
        [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
        public Types.Detail Detail { get; set; } = new Types.Detail();

        /// <summary>
        /// 获取或设置新版商品类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cats_v2")]
        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
        public IList<Types.Category>? CategoryV2List { get; set; }

        /// <summary>
        /// 获取或设置商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrs")]
        [System.Text.Json.Serialization.JsonPropertyName("attrs")]
        public IList<Types.Attribute>? AttributeList { get; set; }

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
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU>? SKUList { get; set; }

        /// <summary>
        /// 获取或设置更新后是否立即上架。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("listing")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("listing")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? RequireListing { get; set; }
    }
}
