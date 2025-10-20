namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/stocks/{stock_id}/refund-flow-by-day 接口的响应。</para>
    /// </summary>
    public class GetMarketingFavorStockRefundFlowByDayResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置流水文件下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_refundflow_hash")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_refundflow_hash")]
        public string HashValue { get; set; } = default!;

        /// <summary>
        /// 获取或设置记录总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_refundflow_count")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_refundflow_count")]
        public int FlowCount { get; set; }
    }
}
