namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /combine-transactions/id/{combine_transaction_id} 接口的请求。</para>
    /// </summary>
    public class GetCombineTransactionByCombineTransactionIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置合单微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CombineTransactionId { get; set; } = string.Empty;
    }
}
