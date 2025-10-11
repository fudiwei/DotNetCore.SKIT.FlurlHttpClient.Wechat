using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/employees/{employee_id}/revoke 接口的响应。</para>
    /// </summary>
    public class RevokeGetWeBusinessPayEmployeeResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户企业员工 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_state")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_state")]
        public string AuthorizationState { get; set; } = default!;

        /// <summary>
        /// 获取或设置解除授权时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_revoked_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_revoked_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset RevokeTime { get; set; }

        /// <summary>
        /// 获取或设置失效原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
