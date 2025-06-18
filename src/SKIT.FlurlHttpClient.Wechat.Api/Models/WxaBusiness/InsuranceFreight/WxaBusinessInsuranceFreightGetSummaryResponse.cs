namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/getsummary 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightGetSummaryResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置投保总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置理赔总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claim_num")]
        [System.Text.Json.Serialization.JsonPropertyName("claim_num")]
        public int ClaimCount { get; set; }

        /// <summary>
        /// 获取或设置理赔成功总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claim_succ_num")]
        [System.Text.Json.Serialization.JsonPropertyName("claim_succ_num")]
        public int ClaimSuccessCount { get; set; }

        /// <summary>
        /// 获取或设置当前保费（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("premium")]
        [System.Text.Json.Serialization.JsonPropertyName("premium")]
        public int PremiumAmount { get; set; }

        /// <summary>
        /// 获取或设置当前账号余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds")]
        [System.Text.Json.Serialization.JsonPropertyName("funds")]
        public int FundsBalance { get; set; }

        /// <summary>
        /// 获取或设置是否不能投保。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_close")]
        [System.Text.Json.Serialization.JsonPropertyName("need_close")]
        public bool NeedClose { get; set; }
    }
}
