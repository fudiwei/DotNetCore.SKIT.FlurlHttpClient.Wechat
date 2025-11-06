namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/transactions/exposure 接口的响应。</para>
    /// </summary>
    public class CreatePayTransactionExposureResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置是否建议曝光微信分付。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fqf_exposure")]
        [System.Text.Json.Serialization.JsonPropertyName("fqf_exposure")]
        public bool IsRecommendExposed { get; set; }

        /// <summary>
        /// 获取或设置曝光凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("market_exposure_token")]
        [System.Text.Json.Serialization.JsonPropertyName("market_exposure_token")]
        public string? MarketExposureToken { get; set; }
    }
}
