using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payroll-card/authentications/{authenticate_number} 接口的响应。</para>
    /// </summary>
    public class GetPayrollCardAuthenticationByAuthenticateNumberResponse : WechatTenpayResponse
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("authenticate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AuthenticateTime { get; set; }

        /// <summary>
        /// 获取或设置核身失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authenticate_failed_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("authenticate_failed_reason")]
        public string? AuthenticateFailedReason { get; set; }
    }
}
