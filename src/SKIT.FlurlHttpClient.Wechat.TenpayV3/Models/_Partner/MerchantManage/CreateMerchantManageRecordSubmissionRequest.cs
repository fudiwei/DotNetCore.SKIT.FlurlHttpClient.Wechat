namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch-manage/mch-manage-records/{manage_record_id}/mch-manage-submissions 接口的请求。</para>
    /// </summary>
    public class CreateMerchantManageRecordSubmissionRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户管理记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ManageRecordId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提交数据（JSON 格式）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_data")]
        [System.Text.Json.Serialization.JsonPropertyName("submit_data")]
        public string SubmitData { get; set; } = "{}";
    }
}
