namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/applyments/business-code/{business_code} 接口的响应。</para>
    /// </summary>
    public class GetBrandApplymentByBusinessCodeResponse : WechatTenpayResponse
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

        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_state")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_state")]
        public string ApplymentState { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_state_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_state_desc")]
        public string ApplymentStateDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权确认二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_confirmation_qr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_confirmation_qr_code")]
        public string? AuthorizationConfirmationQrcodeUrl { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }
    }
}
