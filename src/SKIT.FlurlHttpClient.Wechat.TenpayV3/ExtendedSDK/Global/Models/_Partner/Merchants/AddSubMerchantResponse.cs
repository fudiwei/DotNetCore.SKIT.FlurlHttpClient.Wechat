namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchants 接口的响应。</para>
    /// </summary>
    public class AddSubMerchantResponse : WechatTenpayGlobalResponse
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

        /// <summary>
        /// 获取或设置 H5 支付认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h5_authorization_state")]
        [System.Text.Json.Serialization.JsonPropertyName("h5_authorization_state")]
        public string? H5AuthorizationState { get; set; }
    }
}
