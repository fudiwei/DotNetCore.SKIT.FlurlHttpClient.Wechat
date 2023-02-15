namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/cancelpay 接口的请求。</para>
    /// </summary>
    public class WxaGameCancelPayRequest : WxaGameRequestBase, IInferable<WxaGameCancelPayRequest, WxaGameCancelPayResponse>
    {
        /// <summary>
        /// 获取或设置扣除游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_bill_no")]
        public string PayBillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退回游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置本次退回的退游戏币的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/wxa/game/cancelpay";
        }
    }
}
