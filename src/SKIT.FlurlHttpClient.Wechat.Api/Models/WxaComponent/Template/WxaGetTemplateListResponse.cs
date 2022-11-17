namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/gettemplatelist 接口的响应。</para>
    /// </summary>
    public class WxaGetTemplateListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置小程序的页面。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序的标签。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag")]
                        public string Tag { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序页面的标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_id")]
                        public int FirstCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置一级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                        public string FirstCategoryName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_id")]
                        public int SecondCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                        public string SecondCategoryName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                        public int? ThirdCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                        public string? ThirdCategoryName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_type")]
                [System.Text.Json.Serialization.JsonPropertyName("template_type")]
                public int TemplateType { get; set; }

                /// <summary>
                /// 获取或设置用户自定义版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_version")]
                [System.Text.Json.Serialization.JsonPropertyName("user_version")]
                public string UserVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户自定义版本描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
                public string UserDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置添加为模板的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置添模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("draft_id")]
                [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
                public long DraftId { get; set; }

                /// <summary>
                /// 获取或设置开发小程序的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_miniprogram_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("source_miniprogram_appid")]
                public string SourceMiniprogramAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开发小程序的名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("source_miniprogram")]
                public string SourceMiniprogram { get; set; } = default!;

                /// <summary>
                /// 获取或设置标准模板的场景标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_scene")]
                public int? AuditScene { get; set; }

                /// <summary>
                /// 获取或设置标准模板的审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public int? AuditStatus { get; set; }

                /// <summary>
                /// 获取或设置标准模板的审核驳回的原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string? Reason { get; set; }

                /// <summary>
                /// 获取或设置类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_list")]
                [System.Text.Json.Serialization.JsonPropertyName("category_list")]
                public Types.Category[] CategoryList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_list")]
        [System.Text.Json.Serialization.JsonPropertyName("template_list")]
        public Types.Template[] TemplateList { get; set; } = default!;
    }
}
