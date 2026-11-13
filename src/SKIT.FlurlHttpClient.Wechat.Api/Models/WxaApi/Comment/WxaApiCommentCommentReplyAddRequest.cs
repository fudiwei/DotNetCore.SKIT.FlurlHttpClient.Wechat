namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/comment/commentreply/add 接口的请求。</para>
    /// </summary>
    public class WxaApiCommentCommentReplyAddRequest : WechatApiRequest, IInferable<WxaApiCommentCommentReplyAddRequest, WxaApiCommentCommentReplyAddResponse>
    {
        /// <summary>
        /// 获取或设置评价 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentId")]
        [System.Text.Json.Serialization.JsonPropertyName("commentId")]
        public string? CommentId { get; set; }

        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replyId")]
        [System.Text.Json.Serialization.JsonPropertyName("replyId")]
        public string? ReplyId { get; set; }

        /// <summary>
        /// 获取或设置评论的内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }
    }
}
