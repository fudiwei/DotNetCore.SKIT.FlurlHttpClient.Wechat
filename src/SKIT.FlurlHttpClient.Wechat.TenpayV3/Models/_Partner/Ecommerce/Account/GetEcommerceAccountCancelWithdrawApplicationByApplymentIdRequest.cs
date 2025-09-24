namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/account/apply-cancel-withdraw/applyment-id/{applyment_id} 接口的请求。</para>
    /// </summary>
    public class GetEcommerceAccountCancelWithdrawApplicationByApplymentIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付注销提现申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplymentId { get; set; } = string.Empty;
    }
}
