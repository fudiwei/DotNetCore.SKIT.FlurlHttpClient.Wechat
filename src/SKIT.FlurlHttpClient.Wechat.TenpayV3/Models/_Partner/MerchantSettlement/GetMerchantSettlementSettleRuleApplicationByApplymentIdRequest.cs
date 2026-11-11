namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-settlement/merchant-settle-rule-applications/{application_id} 接口的请求。</para>
    /// </summary>
    public class GetMerchantSettlementSettleRuleApplicationByApplymentIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ApplymentId { get; set; }
    }
}
