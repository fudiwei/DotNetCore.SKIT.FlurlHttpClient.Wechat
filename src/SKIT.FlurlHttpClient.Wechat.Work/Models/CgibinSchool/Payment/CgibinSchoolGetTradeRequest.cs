namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/get_trade 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolGetTradeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置收款项目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
        public string TradeNumber { get; set; } = string.Empty;
    }
}
