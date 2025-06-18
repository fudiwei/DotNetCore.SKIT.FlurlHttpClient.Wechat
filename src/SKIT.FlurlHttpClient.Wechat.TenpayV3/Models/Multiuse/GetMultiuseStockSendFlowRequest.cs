namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /multiuse/stocks/{stock_id}/send-flow 接口的请求。</para>
    /// </summary>
    public class GetMultiuseStockSendFlowRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockId { get; set; } = string.Empty;
    }
}
