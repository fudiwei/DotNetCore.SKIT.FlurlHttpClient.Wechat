namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /profitsharing/orders/{out_order_no} 接口的请求。</para>
    /// </summary>
    public class GetProfitSharingOrderByOutOrderNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutOrderNumber { get; set; } = string.Empty;
    }
}
