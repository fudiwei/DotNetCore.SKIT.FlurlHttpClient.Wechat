using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payroll-card/wesure/insurance 接口的请求。</para>
    /// </summary>
    public class CreatePayrollCardWesureInsuranceRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微保保单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wesure_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("wesure_order_no")]
        public string WesureOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险公司保单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insurance_company_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("insurance_company_order_no")]
        public string InsuranceCompanyOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insurance_company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("insurance_company_name")]
        public string InsuranceCompanyName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置投保状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insure_state")]
        [System.Text.Json.Serialization.JsonPropertyName("insure_state")]
        public string InsureState { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保障生效时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insure_effect_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("insure_effect_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset InsureEffectTime { get; set; }

        /// <summary>
        /// 获取或设置保障失效时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insure_invalid_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("insure_invalid_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset InsureInvalidTime { get; set; }
    }
}
