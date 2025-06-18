namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /pay/partner/transactions/out-trade-no/{out_trade_no} 接口的请求。</para>
    /// </summary>
    public class GetPayPartnerTransactionByOutTradeNumberRequest : GetPayTransactionByOutTradeNumberRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
