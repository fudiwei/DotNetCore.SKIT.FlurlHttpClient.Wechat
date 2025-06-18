using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/locallife/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductLocalLifeUpdateRequest : WechatApiRequest, IInferable<ChannelsECProductLocalLifeUpdateRequest, ChannelsECProductLocalLifeUpdateResponse>
    {
        public static class Types
        {
            public class Qualification : ChannelsECProductLocalLifeAddRequest.Types.Qualification
            {
            }

            public class MiniProgramPage : ChannelsECProductLocalLifeAddRequest.Types.MiniProgramPage
            {
            }

            public class SKU : ChannelsECProductLocalLifeAddRequest.Types.SKU
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
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品三级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public long ThirdCategoryId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 获取或设置主图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_imgs")]
        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
        public IList<string> HeadImageUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_qua_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("product_qua_infos")]
        public IList<Types.Qualification>? ProductQualificationList { get; set; }

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
        public IDictionary<string, string> AttributeKeyValueMap { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
