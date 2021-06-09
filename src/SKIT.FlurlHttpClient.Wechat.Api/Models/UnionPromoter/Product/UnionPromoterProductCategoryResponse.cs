using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/product/category 接口的响应。</para>
    /// </summary>
    public class UnionPromoterProductCategoryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("catId")]
                [System.Text.Json.Serialization.JsonPropertyName("catId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int CategoryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productCats")]
        [System.Text.Json.Serialization.JsonPropertyName("productCats")]

        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
