namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id}/submit 接口的请求。</para>
    /// </summary>
    public class CreateMerchantOperationManageEnhancedDueDiligenceSubmitRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置尽调单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DueDiligenceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提交资料 JSON 内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_data")]
        [System.Text.Json.Serialization.JsonPropertyName("submit_data")]
        public string SubmitDataJson { get; set; } = "{}";
    }
}
