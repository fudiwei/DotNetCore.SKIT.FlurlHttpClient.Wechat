using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/spu/get 接口的响应。</para>
    /// </summary>
    public class ShopSPUGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SPU
            {
                public static class Types
                {
                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置商品描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品详情图片 Url 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("imgs")]
                        [System.Text.Json.Serialization.JsonPropertyName("imgs")]
                        public string[] ImageUrlList { get; set; } = default!;
                    }

                    public class Audit
                    {
                        /// <summary>
                        /// 获取或设置审核单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                        public string AuditId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置提交时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("submit_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("submit_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset SubmitTime { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? AuditTime { get; set; }

                        /// <summary>
                        /// 获取或设置拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }
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

                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public string OutSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置缩略图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumb_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                        public string ThumbnailUrl { get; set; } = default!;

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
                        public Attribute[] AttributeList { get; set; } = default!;
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
                /// 获取或设置小程序商品页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置主图 Url 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_img")]
                [System.Text.Json.Serialization.JsonPropertyName("head_img")]
                public string[] HeadImageUrlList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品资质图片 Url 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_pics")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_pics")]
                public string[]? QualificationPictureUrlList { get; set; }

                /// <summary>
                /// 获取或设置商品详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc_info")]
                [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
                public Types.Detail Detail { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
                public Types.Audit Audit { get; set; } = default!;

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
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[]? SKUList { get; set; }

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 SPU 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu")]
        [System.Text.Json.Serialization.JsonPropertyName("spu")]
        public Types.SPU SPU { get; set; } = default!;
    }
}
