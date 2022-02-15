namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /apply4subject/applyment 接口的响应。</para>
    /// </summary>
    public class GetApplyForSubjectApplymentByBusinessCodeResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_state")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_state")]
        public string ApplymentState { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序码图片数据（经 Base64 编码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_data")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_data")]
        public string? QrcodeData { get; set; }

        /// <summary>
        /// 获取或设置驳回参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_param")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_param")]
        public string? RejectParameter { get; set; }

        /// <summary>
        /// 获取或设置驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }
    }
}
