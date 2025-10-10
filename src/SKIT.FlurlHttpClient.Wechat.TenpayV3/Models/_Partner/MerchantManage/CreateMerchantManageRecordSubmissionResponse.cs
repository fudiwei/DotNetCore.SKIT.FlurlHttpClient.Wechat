namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch-manage/mch-manage-records/{manage_record_id}/mch-manage-submissions 接口的响应。</para>
    /// </summary>
    public class CreateMerchantManageRecordSubmissionResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户管理提交资料记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_submission_id")]
        [System.Text.Json.Serialization.JsonPropertyName("manage_submission_id")]
        public string ManageSubmissionId { get; set; } = default!;
    }
}
