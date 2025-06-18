namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /compliance/inactive-merchant-identity-verification/merchants 接口的响应。</para>
    /// </summary>
    public class CreateComplianceInactiveMerchantIdentityVerificationResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置核实单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verification_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verification_id")]
        public string VerificationId { get; set; } = default!;
    }
}
