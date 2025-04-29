namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/comment/apikfquota/reset 接口的请求。</para>
    /// </summary>
    public class WxaApiCommentApiKfQuotaResetRequest : WechatApiRequest, IInferable<WxaApiCommentApiKfQuotaResetRequest, WxaApiCommentApiKfQuotaResetResponse>
    {
        /// <summary>
        /// 获取或设置评价 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentId")]
        [System.Text.Json.Serialization.JsonPropertyName("commentId")]
        public string CommentId { get; set; } = string.Empty;
    }
}
