namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch_operate/risk/withdrawl-apply/applyment-id/{applyment_id} 接口的请求。</para>
    /// </summary>
    public class GetMerchantOperateRiskWithdrawlApplyByApplymentIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置提现申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplymentId { get; set; } = string.Empty;
    }
}
