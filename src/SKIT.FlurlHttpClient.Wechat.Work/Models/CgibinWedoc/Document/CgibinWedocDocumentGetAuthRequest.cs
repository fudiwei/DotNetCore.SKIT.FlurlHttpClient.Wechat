namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/doc_get_auth 接口的请求。</para>
    /// </summary>
    public class CgibinWedocDocumentGetAuthRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;
    }
}
