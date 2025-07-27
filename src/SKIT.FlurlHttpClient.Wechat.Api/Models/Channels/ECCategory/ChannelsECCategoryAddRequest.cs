using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECCategoryAddRequest : WechatApiRequest, IInferable<ChannelsECCategoryAddRequest, ChannelsECCategoryAddResponse>
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cat_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                        public long CategoryId { get; set; }
                    }

                    public class LicenseGroup
                    {
                        public static class Types
                        {
                            public class License
                            {
                                public static class Types
                                {
                                    public class Field
                                    {
                                        /// <summary>
                                        /// 获取或设置字段键。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("key")]
                                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                                        public string Key { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置字段值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public string Value { get; set; } = string.Empty;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置证照 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("license_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("license_id")]
                                public long LicenseId { get; set; }

                                /// <summary>
                                /// 获取或设置证照图片文件 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("file_id_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("file_id_list")]
                                public IList<string>? FileIdList { get; set; }

                                /// <summary>
                                /// 获取或设置证照字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("license_field_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("license_field_list")]
                                public IList<Types.Field>? FieldList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置证照组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license_group_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_group_id")]
                        public long LicenseGroupId { get; set; }

                        /// <summary>
                        /// 获取或设置证照信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license")]
                        [System.Text.Json.Serialization.JsonPropertyName("license")]
                        public Types.License License { get; set; } = new Types.License();
                    }

                    public class Brand
                    {
                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                        public long BrandId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Obsolete("相关接口或字段于 2024-10-28 下线。")]
                [Newtonsoft.Json.JsonProperty("level1")]
                [System.Text.Json.Serialization.JsonPropertyName("level1")]
                public long? FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Obsolete("相关接口或字段于 2024-10-28 下线。")]
                [Newtonsoft.Json.JsonProperty("level2")]
                [System.Text.Json.Serialization.JsonPropertyName("level2")]
                public long? SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Obsolete("相关接口或字段于 2024-10-28 下线。")]
                [Newtonsoft.Json.JsonProperty("level3")]
                [System.Text.Json.Serialization.JsonPropertyName("level3")]
                public long? ThirdCategoryId { get; set; }
                
                /// <summary>
                /// 获取或设置新版分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cats_v2")]
                [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                public IList<Types.Category>? CategoryV2List { get; set; }

                /// <summary>
                /// 获取或设置是否为新版证照组申请。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_new_apply_cat")]
                [System.Text.Json.Serialization.JsonPropertyName("is_new_apply_cat")]
                public bool? IsNewApplyCategory { get; set; }

                /// <summary>
                /// 获取或设置资质材料图片文件 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                public IList<string>? CertificateFileIdList { get; set; }

                /// <summary>
                /// 获取或设置报备函文件 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("baobeihan")]
                [System.Text.Json.Serialization.JsonPropertyName("baobeihan")]
                public IList<string>? BaobeihanFileIdList { get; set; }

                /// <summary>
                /// 获取或设置资质材料图片文件 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jingyingzhengming")]
                [System.Text.Json.Serialization.JsonPropertyName("jingyingzhengming")]
                public IList<string>? JingyingzhengmingFileIdList { get; set; }

                /// <summary>
                /// 获取或设置带货口碑图片文件 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("daihuokoubei")]
                [System.Text.Json.Serialization.JsonPropertyName("daihuokoubei")]
                public IList<string>? DaihuokoubeiFileIdList { get; set; }

                /// <summary>
                /// 获取或设置入住资质图片文件 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ruzhuzhizhi")]
                [System.Text.Json.Serialization.JsonPropertyName("ruzhuzhizhi")]
                public IList<string>? RuzhuzizhiFileIdList { get; set; }

                /// <summary>
                /// 获取或设置经营流水图片文件 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jingyingliushui")]
                [System.Text.Json.Serialization.JsonPropertyName("jingyingliushui")]
                public IList<string>? JingyingliushuiFileIdList { get; set; }

                /// <summary>
                /// 获取或设置补充材料图片文件 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buchongcailiao")]
                [System.Text.Json.Serialization.JsonPropertyName("buchongcailiao")]
                public IList<string>? BuchongcailiaoFileIdList { get; set; }

                /// <summary>
                /// 获取或设置经营平台。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jingyingpingtai")]
                [System.Text.Json.Serialization.JsonPropertyName("jingyingpingtai")]
                public string? Jingyingpingtai { get; set; }

                /// <summary>
                /// 获取或设置账号名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("zhanghaomingcheng")]
                [System.Text.Json.Serialization.JsonPropertyName("zhanghaomingcheng")]
                public string? Zhanghaomingcheng { get; set; }

                /// <summary>
                /// 获取或设置证照组列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_group_list")]
                [System.Text.Json.Serialization.JsonPropertyName("license_group_list")]
                public IList<Types.LicenseGroup>? LicenseGroupList { get; set; }

                /// <summary>
                /// 获取或设置品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_list")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_list")]
                public IList<Types.Brand>? BrandList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_info")]
        [System.Text.Json.Serialization.JsonPropertyName("category_info")]
        public Types.Category Category { get; set; } = new Types.Category();
    }
}
