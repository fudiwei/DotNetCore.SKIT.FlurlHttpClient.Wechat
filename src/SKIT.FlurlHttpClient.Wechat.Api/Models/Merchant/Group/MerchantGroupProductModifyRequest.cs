using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/group/productmod 接口的请求。</para>
    /// </summary>
    public class MerchantGroupProductModifyRequest : WechatApiRequest, IMapResponse<MerchantGroupProductModifyRequest, MerchantGroupProductModifyResponse>
    {
        public static class Types
        {
            public class Product
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string ProductId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置修改操作。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mod_action")]
                [System.Text.Json.Serialization.JsonPropertyName("mod_action")]
                public int Action { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
