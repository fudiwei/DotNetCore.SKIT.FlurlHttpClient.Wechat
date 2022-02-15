namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getpayfororder 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGetPayForOrderRequest : WechatApiRequest, IMapResponse<WxaBusinessGetPayForOrderRequest, WxaBusinessGetPayForOrderResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置微信索要单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string OrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置游戏业务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;
    }
}
