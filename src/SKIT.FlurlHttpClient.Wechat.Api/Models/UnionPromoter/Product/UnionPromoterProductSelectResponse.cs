using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/product/select 接口的响应。</para>
    /// </summary>
    public class UnionPromoterProductSelectResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product : UnionPromoterProductListResponse.Types.Product
            {
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productList")]
        [System.Text.Json.Serialization.JsonPropertyName("productList")]

        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
