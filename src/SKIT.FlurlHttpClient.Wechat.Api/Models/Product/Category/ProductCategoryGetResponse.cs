using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/category/get 接口的响应。</para>
    /// </summary>
    public class ProductCategoryGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置上级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("f_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("f_cat_id")]
                public int ParentCategoryId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_list")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
