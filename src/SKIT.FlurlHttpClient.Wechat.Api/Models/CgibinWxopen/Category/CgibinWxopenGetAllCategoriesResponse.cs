namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/wxopen/getallcategories 接口的响应。</para>
    /// </summary>
    public class CgibinWxopenGetAllCategoriesResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CategoryList
            {
                /// <summary>
                /// 获取或设置类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categories")]
                [System.Text.Json.Serialization.JsonPropertyName("categories")]
                public CategoryItem[] Items { get; set; } = default!;
            }

            public class CategoryItem
            {
                public static class Types
                {
                    public class Qualification
                    {
                        public static class Types
                        {
                            public class File
                            {
                                public static class Types
                                {
                                    public class Example
                                    {
                                        /// <summary>
                                        /// 获取或设置资质文件名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置资质文件示例 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                        public string? ExampleUrl { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置资质文件示例列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("inner_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("inner_list")]
                                public Types.Example[] ExampleList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置资质文件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exter_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("exter_list")]
                        public Types.File[] FileList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资质备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string? Remark { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置类目层级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int? Level { get; set; }

                /// <summary>
                /// 获取或设置上级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("father")]
                [System.Text.Json.Serialization.JsonPropertyName("father")]
                public int? ParentCategoryId { get; set; }

                /// <summary>
                /// 获取或设置下级类目 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("children")]
                [System.Text.Json.Serialization.JsonPropertyName("children")]
                public int[]? SubCategoryIdList { get; set; }

                /// <summary>
                /// 获取或设置敏感类目类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sensitive_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sensitive_type")]
                public int? SensitiveType { get; set; }

                /// <summary>
                /// 获取或设置资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualify")]
                [System.Text.Json.Serialization.JsonPropertyName("qualify")]
                public Types.Qualification? Qualification { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories_list")]
        [System.Text.Json.Serialization.JsonPropertyName("categories_list")]
        public Types.CategoryList CategoryList { get; set; } = default!;
    }
}
