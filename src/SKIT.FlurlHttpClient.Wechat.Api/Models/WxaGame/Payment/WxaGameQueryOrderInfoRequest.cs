namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/queryorderinfo 接口的请求。</para>
    /// </summary>
    public class WxaGameQueryOrderInfoRequest : WxaGamePaymentRequestBase, IInferable<WxaGameQueryOrderInfoRequest, WxaGameQueryOrderInfoResponse>
    {
        /// <summary>
        /// 获取或设置外部订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
        public int BusinessType { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/wxa/game/queryorderinfo";
        }
    }
}
