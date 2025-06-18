namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/comment/commentreply/add 接口的请求。</para>
    /// </summary>
    public class WxaApiCommentReplyAddRequest : WechatApiRequest, IInferable<WxaApiCommentReplyAddRequest, WxaApiCommentReplyAddResponse>
    {
        /// <summary>
        /// 获取或设置评价 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentId")]
        [System.Text.Json.Serialization.JsonPropertyName("commentId")]
        public string CommentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置评论的内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
