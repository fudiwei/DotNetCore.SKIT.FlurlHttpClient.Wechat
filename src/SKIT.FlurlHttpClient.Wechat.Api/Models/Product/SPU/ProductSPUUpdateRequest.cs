using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/update 接口的请求。</para>
    /// </summary>
    public class ProductSPUUpdateRequest : WechatApiRequest, IMapResponse<ProductSPUUpdateRequest, ProductSPUUpdateResponse>
    {
        public static class Types
        {
            public class Description : ProductSPUAddRequest.Types.Detail
            {
            }

            public class Category : ProductSPUAddRequest.Types.Category
            {
            }

            public class Attribute : ProductSPUAddRequest.Types.Attribute
            {
            }

            public class Express : ProductSPUAddRequest.Types.Express
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
        public Types.Description Description { get; set; } = new Types.Description();

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
        public Types.Express Express { get; set; } = new Types.Express();
    }
}
