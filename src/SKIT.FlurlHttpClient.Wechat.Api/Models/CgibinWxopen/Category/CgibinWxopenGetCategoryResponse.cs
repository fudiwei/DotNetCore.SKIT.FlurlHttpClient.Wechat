namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/wxopen/getcategory 接口的响应。</para>
    /// </summary>
    public class CgibinWxopenGetCategoryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first")]
                [System.Text.Json.Serialization.JsonPropertyName("first")]
                public int FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置一级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_name")]
                [System.Text.Json.Serialization.JsonPropertyName("first_name")]
                public string FirstCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second")]
                [System.Text.Json.Serialization.JsonPropertyName("second")]
                public int SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_name")]
                [System.Text.Json.Serialization.JsonPropertyName("second_name")]
                public string SecondCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public int AuditStatus { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                public string? AuditRejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories")]
        [System.Text.Json.Serialization.JsonPropertyName("categories")]
        public Types.Category[] CategoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置一个更改周期内可以添加类目的次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int ModifyLimit { get; set; }

        /// <summary>
        /// 获取或设置本更改周期内还可以添加类目的次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota")]
        [System.Text.Json.Serialization.JsonPropertyName("quota")]
        public int ModifyQuota { get; set; }

        /// <summary>
        /// 获取或设置最多可以设置的类目数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("category_limit")]
        public int MaxCategoryCount { get; set; } = default!;
    }
}
