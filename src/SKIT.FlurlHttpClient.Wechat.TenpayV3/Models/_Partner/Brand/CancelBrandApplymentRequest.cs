namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/applyments/cancel-applyment 接口的请求。</para>
    /// </summary>
    public class CancelBrandApplymentRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置业务申请编号。与字段 <see cref="ApplymentId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string? BusinessCode { get; set; }

        /// <summary>
        /// 获取或设置微信支付申请单号。与字段 <see cref="BusinessCode"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public string? ApplymentId { get; set; }
    }
}
