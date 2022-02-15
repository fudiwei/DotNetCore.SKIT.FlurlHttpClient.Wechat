namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/mass/delete 接口的请求。</para>
    /// </summary>
    public class CgibinMessageMassDeleteRequest : WechatApiRequest, IMapResponse<CgibinMessageMassDeleteRequest, CgibinMessageMassDeleteResponse>
    {
        /// <summary>
        /// 获取或设置群发消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置要删除的文章在图文消息中的位置（从 1 开始；不指定则删除全部）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_idx")]
        [System.Text.Json.Serialization.JsonPropertyName("article_idx")]
        public int? ArticleIndex { get; set; }
    }
}
