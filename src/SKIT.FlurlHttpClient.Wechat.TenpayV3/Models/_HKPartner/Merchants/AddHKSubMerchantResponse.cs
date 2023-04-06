namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchants 接口的响应。</para>
    /// </summary>
    public class AddHKSubMerchantResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置验证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verification_status")]
        [System.Text.Json.Serialization.JsonPropertyName("verification_status")]
        public string? VerificationStatus { get; set; }

        /// <summary>
        /// 获取或设置验证状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? VerificationStatusDescription { get; set; }
    }
}
