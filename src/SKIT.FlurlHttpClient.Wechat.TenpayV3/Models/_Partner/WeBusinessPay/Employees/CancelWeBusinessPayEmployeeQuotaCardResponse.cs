using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/employees/{employee_id}/quota-cards/{card_no}/cancel 接口的响应。</para>
    /// </summary>
    public class CancelWeBusinessPayEmployeeQuotaCardResponse : WechatTenpayResponse
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
        /// 获取或设置微信授权关系 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employee_id")]
        [System.Text.Json.Serialization.JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业支付额度卡卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_no")]
        [System.Text.Json.Serialization.JsonPropertyName("card_no")]
        public string CardNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡片状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_state")]
        [System.Text.Json.Serialization.JsonPropertyName("card_state")]
        public string CardState { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡片失效时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_disabled_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("card_disabled_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset DisableTime { get; set; }
    }
}
