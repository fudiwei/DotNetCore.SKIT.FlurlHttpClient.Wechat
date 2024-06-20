namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/is_trade_management_confirmation_completed 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderIsTradeManagementConfirmationCompletedRequest : WechatApiRequest, IInferable<WxaSecOrderIsTradeManagementConfirmationCompletedRequest, WxaSecOrderIsTradeManagementConfirmationCompletedResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }
    }
}
