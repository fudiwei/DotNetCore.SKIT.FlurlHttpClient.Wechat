namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/stocks/{stock_id}/use-flow-by-day 接口的请求。</para>
    /// </summary>
    public class GetMarketingFavorStockUseFlowByDayRequest : GetMarketingFavorStockUseFlowRequest
    {
        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BillDateString { get; set; } = string.Empty;
    }
}
