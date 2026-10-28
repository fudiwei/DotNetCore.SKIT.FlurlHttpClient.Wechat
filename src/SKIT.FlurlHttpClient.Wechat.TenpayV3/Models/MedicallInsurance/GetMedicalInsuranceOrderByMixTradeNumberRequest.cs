namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /med-ins/orders/mix-trade-no/{mix_trade_no} 接口的请求。</para>
    /// </summary>
    public class GetMedicalInsuranceOrderByMixTradeNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置医保自费混合订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MixTradeNumber { get; set; }
    }
}
