namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /refunds/id/{refund_id} 接口的请求。</para>
    /// </summary>
    public class GetHKRefundByIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RefundId { get; set; } = string.Empty;
    }
}
