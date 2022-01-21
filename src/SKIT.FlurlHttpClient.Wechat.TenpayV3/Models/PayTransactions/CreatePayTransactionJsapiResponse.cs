namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/transactions/jsapi 接口的响应。</para>
    /// </summary>
    public class CreatePayTransactionJsapiResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预支付交易会话标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; } = default!;
    }
}
