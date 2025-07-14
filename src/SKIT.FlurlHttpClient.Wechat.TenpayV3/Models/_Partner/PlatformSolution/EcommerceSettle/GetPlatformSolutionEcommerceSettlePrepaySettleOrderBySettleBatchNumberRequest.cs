namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/settle/prepay-settle-orders/{settle_batch_no} 接口的请求。</para>
    /// </summary>
    public class GetPlatformSolutionEcommerceSettlePrepaySettleOrderBySettleBatchNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付结算批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SettleBatchNumber { get; set; } = string.Empty;
    }
}
