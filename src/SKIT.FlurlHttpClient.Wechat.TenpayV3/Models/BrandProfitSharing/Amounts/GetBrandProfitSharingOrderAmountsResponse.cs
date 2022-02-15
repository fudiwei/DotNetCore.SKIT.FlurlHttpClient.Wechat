namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/profitsharing/orders/{transaction_id}/amounts 接口的响应。</para>
    /// </summary>
    public class GetBrandProfitSharingOrderAmountsResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单剩余待分金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unsplit_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("unsplit_amount")]
        public int UnsplitAmount { get; set; }
    }
}
