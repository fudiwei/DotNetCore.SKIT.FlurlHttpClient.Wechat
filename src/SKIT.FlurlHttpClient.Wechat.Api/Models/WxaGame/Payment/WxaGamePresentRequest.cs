namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/present 接口的请求。</para>
    /// </summary>
    public class WxaGamePresentRequest : WxaGamePaymentRequestBase, IInferable<WxaGamePresentRequest, WxaGamePresentResponse>
    {
        /// <summary>
        /// 获取或设置赠送游戏币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置赠送游戏币的个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/wxa/game/present";
        }
    }
}
