namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/createorder 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightCreateOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置保单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_no")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_no")]
        public string PolicyNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置保单截止日期时间戳（单位：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insurance_end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("insurance_end_date")]
        public string InsuranceEndDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置预估理赔金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimate_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("estimate_amount")]
        public int EstimateAmount { get; set; }

        /// <summary>
        /// 获取或设置保费金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("premium")]
        [System.Text.Json.Serialization.JsonPropertyName("premium")]
        public int PremiumAmount { get; set; }
    }
}
