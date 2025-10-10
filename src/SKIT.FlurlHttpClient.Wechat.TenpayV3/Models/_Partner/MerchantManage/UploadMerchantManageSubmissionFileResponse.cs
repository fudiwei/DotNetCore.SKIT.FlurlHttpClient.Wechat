namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch-manage/submission-files/sub-mchid/{sub_mchid}/upload 接口的响应。</para>
    /// </summary>
    public class UploadMerchantManageSubmissionFileResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_id")]
        [System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string FileId { get; set; } = default!;
    }
}
