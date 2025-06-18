namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/cat/get 接口的响应。</para>
    /// </summary>
    public class ShopCategoryGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("first_cat_id")]
                public int FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置一级类目 ID 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_cat_name")]
                [System.Text.Json.Serialization.JsonPropertyName("first_cat_name")]
                public string FirstCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("second_cat_id")]
                public int SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_cat_name")]
                [System.Text.Json.Serialization.JsonPropertyName("second_cat_name")]
                public string SecondCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_cat_id")]
                public int ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_cat_name")]
                [System.Text.Json.Serialization.JsonPropertyName("third_cat_name")]
                public string ThirdCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置类目资质类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
                public int QualificationType { get; set; }

                /// <summary>
                /// 获取或设置类目资质。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification")]
                public string? Qualification { get; set; }

                /// <summary>
                /// 获取或设置商品资质类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_qualification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_qualification_type")]
                public int ProductQualificationType { get; set; }

                /// <summary>
                /// 获取或设置商品资质。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("product_qualification")]
                public string? ProductQualification { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_cat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("third_cat_list")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
