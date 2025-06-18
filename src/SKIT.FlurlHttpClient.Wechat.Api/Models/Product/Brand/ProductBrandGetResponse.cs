namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/brand/get 接口的响应。</para>
    /// </summary>
    public class ProductBrandGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Brand
            {
                public static class Types
                {
                    public class BrandInformation
                    {
                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                        public long BrandId { get; set; }

                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("first_cat_id")]
                public int FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("second_cat_id")]
                public int SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_cat_id")]
                public int ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置品牌信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_info")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_info")]
                public Types.BrandInformation BrandInformation { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置品牌列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brands")]
        [System.Text.Json.Serialization.JsonPropertyName("brands")]
        public Types.Brand[] BrandList { get; set; } = default!;
    }
}
