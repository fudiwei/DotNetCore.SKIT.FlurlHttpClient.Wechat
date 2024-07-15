using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/locallife/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductLocalLifeGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Qualification : ChannelsECProductGetResponse.Types.Product.Types.Qualification
                    {
                    }

                    public class MiniProgramPage
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string PagePath { get; set; } = default!;
                    }

                    public class AuditResult
                    {
                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                        public string? RejectReason { get; set; }
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
                        /// 获取或设置属性字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_attr_map")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_attr_map")]
                        public IDictionary<string, string>? AttributeKeyValueMap { get; set; }
                    }

                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int ProductType { get; set; }

                /// <summary>
                /// 获取或设置名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string ProductName { get; set; } = default!;

                /// <summary>
                /// 获取或设置主图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_imgs")]
                [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
                public string[] HeadImageUrlList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long BrandId { get; set; }

                /// <summary>
                /// 获取或设置商品上线状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("online_status")]
                [System.Text.Json.Serialization.JsonPropertyName("online_status")]
                public int OnlineStatus { get; set; }

                /// <summary>
                /// 获取或设置商品草稿状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("draft_status")]
                [System.Text.Json.Serialization.JsonPropertyName("draft_status")]
                public int DraftStatus { get; set; }

                /// <summary>
                /// 获取或设置商品资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_qua_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("product_qua_infos")]
                public Types.Qualification[]? QualificationList { get; set; }

                /// <summary>
                /// 获取或设置核销跳转出口小程序页面信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_page")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_page")]
                public Types.MiniProgramPage? VerifyPage { get; set; }

                /// <summary>
                /// 获取或设置到店核销类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_at_store")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_at_store")]
                public int? VerifyAtStoreType { get; set; }

                /// <summary>
                /// 获取或设置券码来源类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_source_type")]
                [System.Text.Json.Serialization.JsonPropertyName("code_source_type")]
                public int CodeSourceType { get; set; }

                /// <summary>
                /// 获取或设置商品属性字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_kv_map")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_kv_map")]
                public IDictionary<string, string> AttributeKeyValueMap { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_result")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_result")]
                public Types.AuditResult? AuditResult { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[] SKUList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置线上商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("online_data")]
        [System.Text.Json.Serialization.JsonPropertyName("online_data")]
        public Types.Product? OnlineProduct { get; set; }

        /// <summary>
        /// 获取或设置草稿商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("draft_data")]
        [System.Text.Json.Serialization.JsonPropertyName("draft_data")]
        public Types.Product? DraftProduct { get; set; }
    }
}
