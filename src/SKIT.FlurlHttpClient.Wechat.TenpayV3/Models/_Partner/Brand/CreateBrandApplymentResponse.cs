namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/applyments 接口的响应。</para>
    /// </summary>
    public class CreateBrandApplymentResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string BusinessCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; } = default!;
    }
}
