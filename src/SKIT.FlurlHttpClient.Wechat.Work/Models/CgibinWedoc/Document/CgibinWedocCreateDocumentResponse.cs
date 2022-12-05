namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/create_doc 接口的响应。</para>
    /// </summary>
    public class CgibinWedocCreateDocumentResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置访问链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
