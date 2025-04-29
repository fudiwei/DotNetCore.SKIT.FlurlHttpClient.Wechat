namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/comment/replyandcommentreplylist/get 接口的请求。</para>
    /// </summary>
    public class WxaApiCommentReplyAndCommentReplyListGetRequest : WechatApiRequest, IInferable<WxaApiCommentReplyAndCommentReplyListGetRequest, WxaApiCommentReplyAndCommentReplyListGetResponse>
    {
        /// <summary>
        /// 获取或设置评价 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CommentId { get; set; } = string.Empty;
    }
}
