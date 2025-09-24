namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/account/apply-cancel-withdraw 接口的响应。</para>
    /// </summary>
    public class CreateEcommerceAccountCancelWithdrawApplicationResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信支付注销提现申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户注销申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;
    }
}
