namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/comment/reply/add 接口的请求。</para>
    /// </summary>
    public class CgibinCommentReplyAddRequest : CgibinCommentMarkElectRequest
    {
        /// <summary>
        /// 获取或设置回复内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
