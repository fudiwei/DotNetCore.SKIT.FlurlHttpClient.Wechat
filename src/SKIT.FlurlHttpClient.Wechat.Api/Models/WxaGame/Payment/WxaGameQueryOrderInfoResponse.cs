namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/queryorderinfo 接口的响应。</para>
    /// </summary>
    public class WxaGameQueryOrderInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置道具 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = default!;

        /// <summary>
        /// 获取或设置外部订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_order_no")]
        public string? MerchantOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_state")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_state")]
        public int PayState { get; set; }

        /// <summary>
        /// 获取或设置发货状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_state")]
        [System.Text.Json.Serialization.JsonPropertyName("deliver_state")]
        public int DeliverState { get; set; }

        /// <summary>
        /// 获取或设置支付完成时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_finish_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_finish_time")]
        public long? PayFinishTimestamp { get; set; }
    }
}
