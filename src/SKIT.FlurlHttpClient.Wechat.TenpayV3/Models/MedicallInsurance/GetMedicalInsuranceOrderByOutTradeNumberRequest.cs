namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /med-ins/orders/out-trade-no/{out_trade_no} 接口的请求。</para>
    /// </summary>
    public class GetMedicalInsuranceOrderByOutTradeNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutTradeNumber { get; set; }
    }
}
