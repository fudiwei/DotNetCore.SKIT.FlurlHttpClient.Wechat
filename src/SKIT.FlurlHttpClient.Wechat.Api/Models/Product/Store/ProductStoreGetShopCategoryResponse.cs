namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/store/get_shopcat 接口的响应。</para>
    /// </summary>
    public class ProductStoreGetShopCategoryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopcat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shopcat_id")]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置分类名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopcat_name")]
                [System.Text.Json.Serialization.JsonPropertyName("shopcat_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置上级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("f_shopcat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("f_shopcat_id")]
                public int ParentCategoryId { get; set; }

                /// <summary>
                /// 获取或设置分类层级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_level")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_level")]
                public int Level { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分类列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopcat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("shopcat_list")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
