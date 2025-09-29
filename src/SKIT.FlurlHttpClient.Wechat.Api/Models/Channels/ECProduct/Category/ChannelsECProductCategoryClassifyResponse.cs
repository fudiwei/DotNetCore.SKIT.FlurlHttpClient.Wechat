namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/category/classify 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductCategoryClassifyResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CategoryList
            {
                /// <summary>
                /// 获取或设置类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cats")]
                [System.Text.Json.Serialization.JsonPropertyName("cats")]
                public CategoryItem[] Items { get; set; } = default!;
            }

            public class CategoryItem
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
                        public long CategoryId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置类目信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_info")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_info")]
                public Types.Category Category { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否有该类目的权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_permission")]
                [System.Text.Json.Serialization.JsonPropertyName("has_permission")]
                public bool HasPermission { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推荐类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories")]
        [System.Text.Json.Serialization.JsonPropertyName("categories")]
        public Types.CategoryList[] CategoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否类目错放。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wrong_cat")]
        [System.Text.Json.Serialization.JsonPropertyName("wrong_cat")]
        public bool? IsWrongCategory { get; set; }
    }
}
