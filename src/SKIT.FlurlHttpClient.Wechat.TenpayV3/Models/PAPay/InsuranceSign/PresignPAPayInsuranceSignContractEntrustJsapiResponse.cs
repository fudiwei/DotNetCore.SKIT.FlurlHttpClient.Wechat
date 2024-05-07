namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/insurance-sign/contracts/pre-entrust-sign/jsapi 接口的响应。</para>
    /// </summary>
    public class PresignPAPayInsuranceSignContractEntrustJsapiResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置跳转 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_url")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; } = default!;
    }
}
