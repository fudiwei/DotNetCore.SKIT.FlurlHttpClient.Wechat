namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/redirects 接口的请求。</para>
    /// </summary>
    public class CreateMSEPayRedirectLinkRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string PaymentId { get; set; } = string.Empty;
    }
}
