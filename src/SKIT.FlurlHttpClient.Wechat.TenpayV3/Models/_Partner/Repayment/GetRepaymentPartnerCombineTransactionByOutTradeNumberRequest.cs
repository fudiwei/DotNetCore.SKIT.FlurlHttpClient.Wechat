namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /repayment/combine-transactions/partner/out-trade-no/{combine_out_trade_no} 接口的请求。</para>
    /// </summary>
    public class GetRepaymentPartnerCombineTransactionByOutTradeNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置还款商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CombineOutTradeNumber { get; set; } = string.Empty;
    }
}
