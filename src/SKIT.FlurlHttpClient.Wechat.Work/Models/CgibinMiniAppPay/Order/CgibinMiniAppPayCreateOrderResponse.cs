namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/create_order 接口的响应。</para>
    /// </summary>
    public class CgibinMiniAppPayCreateOrderResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置预支付交易会话标识	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; } = default!;
    }
}
