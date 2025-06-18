namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_merchant_category 接口的响应。</para>
    /// </summary>
    public class WxaGetMerchantCategoryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CategoryList
                    {
                        /// <summary>
                        /// 获取或设置分类列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categories")]
                        [System.Text.Json.Serialization.JsonPropertyName("categories")]
                        public CategoryItem[] Items { get; set; } = default!;
                    }

                    public class CategoryItem : CgibinWxopenGetAllCategoriesResponse.Types.CategoryItem
                    {
                    }
                }

                /// <summary>
                /// 获取或设置分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("all_category_info")]
                [System.Text.Json.Serialization.JsonPropertyName("all_category_info")]
                public Types.CategoryList CategoryList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
