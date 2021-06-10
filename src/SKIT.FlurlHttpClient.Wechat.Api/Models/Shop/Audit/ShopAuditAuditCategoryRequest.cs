using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/audit/audit_category 接口的请求。</para>
    /// </summary>
    public class ShopAuditAuditCategoryRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Audit
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level1")]
                        [System.Text.Json.Serialization.JsonPropertyName("level1")]
                        public int FirstCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level2")]
                        [System.Text.Json.Serialization.JsonPropertyName("level2")]
                        public int SecondCategroyId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level3")]
                        [System.Text.Json.Serialization.JsonPropertyName("level3")]
                        public int ThirdCategroyId { get; set; }

                        /// <summary>
                        /// 获取或设置资质材料图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                        public IList<string>? QualificationUrlList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置营业执照或组织机构代码证图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license")]
                [System.Text.Json.Serialization.JsonPropertyName("license")]
                public string LicenseUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置类目信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_info")]
                [System.Text.Json.Serialization.JsonPropertyName("category_info")]
                public Types.Category Category { get; set; } = new Types.Category();
            }
        }

        /// <summary>
        /// 获取或设置审核单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_req")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_req")]
        public Types.Audit Audit { get; set; } = new Types.Audit();
    }
}
