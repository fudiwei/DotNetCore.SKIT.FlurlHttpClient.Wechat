namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/export/get_job_status 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataExportGetJobStatusResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置结果 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_id")]
        [System.Text.Json.Serialization.JsonPropertyName("result_id")]
        public string? ResultId { get; set; }

        /// <summary>
        /// 获取或设置结果错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("result_errcode")]
        public int? ResultErrorCode { get; set; }

        /// <summary>
        /// 获取或设置结果错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("result_errmsg")]
        public string? ResultErrorMessage { get; set; }
    }
}
