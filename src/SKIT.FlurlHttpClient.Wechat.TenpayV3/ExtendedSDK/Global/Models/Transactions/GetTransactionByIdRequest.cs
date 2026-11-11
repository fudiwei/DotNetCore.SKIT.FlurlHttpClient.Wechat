namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /transactions/id/{transaction_id} 接口的请求。</para>
    /// </summary>
    public class GetTransactionByIdRequest : WechatTenpayGlobalRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TransactionId { get; set; }
    }
}
