namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/export_doc 接口的请求。</para>
    /// </summary>
    public class CgibinOAJournalExportDocumentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置汇报 UUID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("journaluuid")]
        [System.Text.Json.Serialization.JsonPropertyName("journaluuid")]
        public string JournalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;
    }
}
