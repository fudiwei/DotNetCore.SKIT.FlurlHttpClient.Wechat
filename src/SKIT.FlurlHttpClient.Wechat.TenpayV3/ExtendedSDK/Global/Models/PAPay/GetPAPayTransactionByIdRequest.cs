namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/transactions/{transaction_id} 接口的请求。</para>
    /// </summary>
    public class GetPAPayTransactionByIdRequest : WechatTenpayGlobalRequest
    {
        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TransactionId { get; set; } = string.Empty;
    }
}
