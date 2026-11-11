namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /transactions/jsapi 接口的响应。</para>
    /// </summary>
    public class CreateTransactionJsapiResponse : WechatTenpayGlobalResponse
    {
        /// <summary>
        /// 获取或设置预支付交易会话标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string? PrepayId { get; set; }
    }
}
