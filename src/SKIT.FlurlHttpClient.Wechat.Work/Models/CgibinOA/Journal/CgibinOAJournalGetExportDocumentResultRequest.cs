namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/get_export_doc_result 接口的请求。</para>
    /// </summary>
    public class CgibinOAJournalGetExportDocumentResultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置导出任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = string.Empty;
    }
}
