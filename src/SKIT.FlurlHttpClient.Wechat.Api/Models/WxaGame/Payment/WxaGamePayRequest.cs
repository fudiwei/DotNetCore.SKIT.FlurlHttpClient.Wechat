namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/pay 接口的请求。</para>
    /// </summary>
    public class WxaGamePayRequest : WxaGamePaymentRequestBase, IInferable<WxaGamePayRequest, WxaGamePayResponse>
    {
        /// <summary>
        /// 获取或设置扣除游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置扣除游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置道具名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payitem")]
        [System.Text.Json.Serialization.JsonPropertyName("payitem")]
        public string? PayItem { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/wxa/game/pay";
        }
    }
}
