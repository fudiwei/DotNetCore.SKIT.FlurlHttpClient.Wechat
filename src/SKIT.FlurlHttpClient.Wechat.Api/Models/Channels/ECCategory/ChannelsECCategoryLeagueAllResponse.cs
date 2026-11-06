namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/category/league/all 接口的响应。</para>
    /// </summary>
    public class ChannelsECCategoryLeagueAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class CategoryAndQualification : ShopECCategoryAllResponse.Types.Category.Types.__zz__CategoryAndQualification
                    {
                        public static class Types
                        {
                            public class Category : ShopECCategoryAllResponse.Types.Category.Types.CategoryAndQualification.Types.Category
                            {
                            }

                            public class Qualification : ShopECCategoryAllResponse.Types.Category.Types.CategoryAndQualification.Types.Qualification
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置类目信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cat")]
                        [System.Text.Json.Serialization.JsonPropertyName("cat")]
                        public Types.Category? Category { get; set; }

                        /// <summary>
                        /// 获取或设置资质信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qua")]
                        [System.Text.Json.Serialization.JsonPropertyName("qua")]
                        public Types.Qualification? Qualification { get; set; }

                        /// <summary>
                        /// 获取或设置商品资质信息。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2024-03-19 下线。")]
                        [Newtonsoft.Json.JsonProperty("product_qua")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_qua")]
                        public Types.Qualification? ProductQualification { get; set; }

                        /// <summary>
                        /// 获取或设置商品资质列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_qua_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_qua_list")]
                        public List<Types.Qualification>? ProductQualificationList { get; set; }

                        /// <summary>
                        /// 获取或设置品牌资质信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_qua")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_qua")]
                        public Types.Qualification? BrandQualification { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置类目和资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_and_qua")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_and_qua")]
                public List<Types.CategoryAndQualification>? CategoryAndQualificationList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Obsolete("相关接口或字段于 2024-10-28 下线。")]
        [Newtonsoft.Json.JsonProperty("cats")]
        [System.Text.Json.Serialization.JsonPropertyName("cats")]
        public List<Types.Category>? CategoryList { get; set; }

        /// <summary>
        /// 获取或设置新版类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cats_v2")]
        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
        public List<Types.Category>? CategoryV2List { get; set; }
    }
}
