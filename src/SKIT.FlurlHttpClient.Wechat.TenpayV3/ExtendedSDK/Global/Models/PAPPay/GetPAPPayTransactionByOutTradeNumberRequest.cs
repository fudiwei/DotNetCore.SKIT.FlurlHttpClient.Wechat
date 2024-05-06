namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/transactions/out-trade-no/{out_trade_no} 接口的请求。</para>
    /// </summary>
    public class GetPAPPayTransactionByOutTradeNumberRequest : WechatTenpayGlobalRequest
    {
        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutTradeNumber { get; set; } = string.Empty;
    }
}
