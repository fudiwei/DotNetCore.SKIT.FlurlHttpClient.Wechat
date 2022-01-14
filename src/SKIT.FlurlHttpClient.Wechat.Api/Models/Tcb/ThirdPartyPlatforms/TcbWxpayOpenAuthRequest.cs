namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/wxpayopenauth 接口的请求。</para>
    /// </summary>
    public class TcbWxpayOpenAuthRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_code")]
        public string MerchantId { get; set; } = string.Empty;
    }
}
