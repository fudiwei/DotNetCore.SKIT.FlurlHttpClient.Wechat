namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/rename_doc 接口的请求。</para>
    /// </summary>
    public class CgibinWedocRenameDocumentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// 获取或设置收集表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("formid")]
        [System.Text.Json.Serialization.JsonPropertyName("formid")]
        public string? FormId { get; set; }

        /// <summary>
        /// 获取或设置新名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_name")]
        [System.Text.Json.Serialization.JsonPropertyName("new_name")]
        public string NewName { get; set; } = string.Empty;
    }
}
