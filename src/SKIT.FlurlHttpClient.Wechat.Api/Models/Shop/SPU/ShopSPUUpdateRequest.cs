using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/spu/update 接口的请求。</para>
    /// </summary>
    public class ShopSPUUpdateRequest : WechatApiRequest, IInferable<ShopSPUUpdateRequest, ShopSPUUpdateResponse>
    {
        public static class Types
        {
            public class Detail : ShopSPUAddRequest.Types.Detail
            {
            }

            public class Attribute : ShopSPUAddRequest.Types.Attribute
            {
            }

            public class SKU : ShopSPUAddRequest.Types.SKU
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
