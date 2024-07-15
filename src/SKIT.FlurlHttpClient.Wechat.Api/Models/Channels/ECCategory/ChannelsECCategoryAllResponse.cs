using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/category/all 接口的响应。</para>
    /// </summary>
    public class ChannelsECCategoryAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class CategoryAndQualification
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
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long CategoryId { get; set; }

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
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long ParentCategoryId { get; set; }

                                /// <summary>
                                /// 获取或设置类目层级。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("level")]
                                [System.Text.Json.Serialization.JsonPropertyName("level")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int Level { get; set; }
                            }

                            public class Qualification
                            {
                                /// <summary>
                                /// 获取或设置资质 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qua_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("qua_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long QualificationId { get; set; }

                                /// <summary>
                                /// 获取或设置资质名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? Name { get; set; }

                                /// <summary>
                                /// 获取或设置资质信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tips")]
                                [System.Text.Json.Serialization.JsonPropertyName("tips")]
                                public string? Tips { get; set; }

                                /// <summary>
                                /// 获取或设置是否需要申请才能用。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("need_to_apply")]
                                [System.Text.Json.Serialization.JsonPropertyName("need_to_apply")]
                                public bool IsApplyRequired { get; set; }

                                /// <summary>
                                /// 获取或设置是否一定要提交资质。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mandatory")]
                                [System.Text.Json.Serialization.JsonPropertyName("mandatory")]
                                public bool IsApplyMandatory { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置类目信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cat")]
                        [System.Text.Json.Serialization.JsonPropertyName("cat")]
                        public Types.Category Category { get; set; } = default!;

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
                        public Types.Qualification[]? ProductQualificationList { get; set; }

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
                public Types.CategoryAndQualification[] CategoryAndQualificationList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cats")]
        [System.Text.Json.Serialization.JsonPropertyName("cats")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
