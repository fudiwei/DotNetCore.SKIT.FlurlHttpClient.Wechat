namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id}/upload 接口的响应。</para>
    /// </summary>
    public class UploadMerchantOperationManageEnhancedDueDiligenceFileResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置文件标识 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_id")]
        [System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string FileId { get; set; } = default!;
    }
}
