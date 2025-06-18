namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/del_doc 接口的请求。</para>
    /// </summary>
    public class CgibinWedocDeleteDocumentRequest : WechatWorkRequest
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
    }
}
