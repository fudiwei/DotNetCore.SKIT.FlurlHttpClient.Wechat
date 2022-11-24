using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payroll-card/authentications 接口的响应。</para>
    /// </summary>
    public class QueryPayrollCardAuthenticationsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Authentication
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家核身单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authenticate_number")]
                [System.Text.Json.Serialization.JsonPropertyName("authenticate_number")]
                public string AuthenticateNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置核身渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authenticate_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("authenticate_scene")]
                public string AuthenticateScene { get; set; } = default!;

                /// <summary>
                /// 获取或设置核身渠道标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authenticate_source")]
                [System.Text.Json.Serialization.JsonPropertyName("authenticate_source")]
                public string AuthenticateSource { get; set; } = default!;

                /// <summary>
                /// 获取或设置项目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("project_name")]
                [System.Text.Json.Serialization.JsonPropertyName("project_name")]
                public string ProjectName { get; set; } = default!;

                /// <summary>
                /// 获取或设置单位名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("employer_name")]
                [System.Text.Json.Serialization.JsonPropertyName("employer_name")]
                public string EmployerName { get; set; } = default!;

                /// <summary>
                /// 获取或设置核身类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authenticate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("authenticate_type")]
                public string AuthenticateType { get; set; } = default!;

                /// <summary>
                /// 获取或设置核身状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authenticate_state")]
                [System.Text.Json.Serialization.JsonPropertyName("authenticate_state")]
                public string AuthenticateState { get; set; } = default!;

                /// <summary>
                /// 获取或设置核身时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authenticate_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("authenticate_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset AuthenticateTime { get; set; }

                /// <summary>
                /// 获取或设置核身失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authenticate_failed_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("authenticate_failed_reason")]
                public string? AuthenticateFailedReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置核身记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Authentication[] AuthenticationList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置合作关系总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
    }
}
