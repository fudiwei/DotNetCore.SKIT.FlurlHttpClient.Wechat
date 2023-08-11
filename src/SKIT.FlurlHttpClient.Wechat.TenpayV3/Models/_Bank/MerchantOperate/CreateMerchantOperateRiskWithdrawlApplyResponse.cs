namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch_operate/risk/withdrawl-apply 接口的响应。</para>
    /// </summary>
    public class CreateMerchantOperateRiskWithdrawlApplyResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户提现申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置提现申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; } = default!;
    }
}
