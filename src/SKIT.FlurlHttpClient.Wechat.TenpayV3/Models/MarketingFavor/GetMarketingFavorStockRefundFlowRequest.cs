namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/stocks/{stock_id}/refund-flow 接口的请求。</para>
    /// </summary>
    public class GetMarketingFavorStockRefundFlowRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? StockId { get; set; }
    }
}
