namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /password-exempt-contract/contracts/qs/pre-entrust-sign/pay-redirect-sign 接口的请求。</para>
    /// </summary>
    public class PresignPasswordExemptContractQsEntrustPayRedirectSignRequest : PresignPasswordExemptContractQsEntrustMiniProgramRequest
    {
        /// <summary>
        /// 获取或设置预支付交易会话标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; } = string.Empty;
    }
}
