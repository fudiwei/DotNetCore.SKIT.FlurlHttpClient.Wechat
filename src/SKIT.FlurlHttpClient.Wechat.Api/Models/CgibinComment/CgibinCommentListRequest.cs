namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/comment/list 接口的请求。</para>
    /// </summary>
    public class CgibinCommentListRequest : WechatApiRequest, IMapResponse<CgibinCommentListRequest, CgibinCommentListResponse>
    {
        /// <summary>
        /// 获取或设置群发消息数据 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_data_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_data_id")]
        public long MessageDataId { get; set; }

        /// <summary>
        /// 获取或设置文章在图文消息中的位置（从 0 开始；不指定则默认第一篇）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index")]
        [System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? ArticleIndex { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin")]
        [System.Text.Json.Serialization.JsonPropertyName("begin")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置评论类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }
}
