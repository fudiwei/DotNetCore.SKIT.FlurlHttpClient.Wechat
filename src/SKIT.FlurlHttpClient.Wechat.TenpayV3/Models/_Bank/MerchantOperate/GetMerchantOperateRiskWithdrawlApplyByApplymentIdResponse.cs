namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch_operate/risk/withdrawl-apply/applyment-id/{applyment_id} 接口的响应。</para>
    /// </summary>
    public class GetMerchantOperateRiskWithdrawlApplyByApplymentIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class WithdrawApplyment : GetMerchantOperateRiskWithdrawlApplyByOutRequestNumberResponse.Types.WithdrawApplyment
            {
            }
        }

        /// <summary>
        /// 获取或设置提现申请单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdrawl_apply")]
        [System.Text.Json.Serialization.JsonPropertyName("withdrawl_apply")]
        public Types.WithdrawApplyment WithdrawApplyment { get; set; } = default!;
    }
}
