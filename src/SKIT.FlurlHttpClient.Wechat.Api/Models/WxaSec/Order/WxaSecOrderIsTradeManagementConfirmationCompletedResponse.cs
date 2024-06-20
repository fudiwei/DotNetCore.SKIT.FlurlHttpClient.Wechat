namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/is_trade_management_confirmation_completed 接口的响应。</para>
    /// </summary>
    public class WxaSecOrderIsTradeManagementConfirmationCompletedResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否已完成交易结算管理确认。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("completed")]
        [System.Text.Json.Serialization.JsonPropertyName("completed")]
        public bool IsCompleted { get; set; }
    }
}
