namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/applyments/submit-sign-verify-info 接口的响应。</para>
    /// </summary>
    public class CreateEcommerceApplymentForSubmitSignVerifyInfoResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信支付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public long ApplymentId { get; set; }
    }
}
