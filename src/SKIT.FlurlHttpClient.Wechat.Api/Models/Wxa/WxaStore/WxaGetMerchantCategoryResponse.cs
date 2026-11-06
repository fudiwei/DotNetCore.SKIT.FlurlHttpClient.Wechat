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
                        public List<CategoryItem>? Items { get; set; }
                    }

                    public class CategoryItem : CgibinWxopenGetAllCategoriesResponse.Types.__zz__CategoryItem
                    {
                        public static class Types
                        {
                            public class Qualification : CgibinWxopenGetAllCategoriesResponse.Types.CategoryItem.Types.__zz__Qualification
                            {
                                public static class Types
                                {
                                    public class File
                                    {
                                        public static class Types
                                        {
                                            public class Example : CgibinWxopenGetAllCategoriesResponse.Types.CategoryItem.Types.Qualification.Types.File.Types.Example
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置资质文件示例列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("inner_list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("inner_list")]
                                        public List<Types.Example>? ExampleList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置资质文件列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("exter_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("exter_list")]
                                public List<Types.File>? FileList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置资质信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualify")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualify")]
                        public Types.Qualification? Qualification { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("all_category_info")]
                [System.Text.Json.Serialization.JsonPropertyName("all_category_info")]
                public Types.CategoryList? CategoryList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
