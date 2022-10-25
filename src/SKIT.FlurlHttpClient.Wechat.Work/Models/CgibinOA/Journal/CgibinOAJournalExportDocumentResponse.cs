namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/export_doc 接口的响应。</para>
    /// </summary>
    public class CgibinOAJournalExportDocumentResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置导出任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;
    }
}
