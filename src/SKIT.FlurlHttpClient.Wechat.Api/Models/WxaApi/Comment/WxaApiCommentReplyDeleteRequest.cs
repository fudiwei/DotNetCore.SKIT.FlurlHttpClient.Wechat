namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/comment/commentreply/delete 接口的请求。</para>
    /// </summary>
    public class WxaApiCommentReplyDeleteRequest : WechatApiRequest, IInferable<WxaApiCommentReplyDeleteRequest, WxaApiCommentReplyDeleteResponse>
    {
        /// <summary>
        /// 获取或设置评价 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentId")]
        [System.Text.Json.Serialization.JsonPropertyName("commentId")]
        public string CommentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replyId")]
        [System.Text.Json.Serialization.JsonPropertyName("replyId")]
        public string ReplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置评论回复 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentReplyId")]
        [System.Text.Json.Serialization.JsonPropertyName("commentReplyId")]
        public string CommentReplyId { get; set; } = string.Empty;
    }
}
