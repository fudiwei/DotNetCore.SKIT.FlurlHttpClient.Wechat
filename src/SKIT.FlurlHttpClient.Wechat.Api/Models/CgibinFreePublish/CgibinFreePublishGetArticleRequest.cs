namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/freepublish/getarticle 接口的请求。</para>
    /// </summary>
    public class CgibinFreePublishGetArticleRequest : WechatApiRequest, IInferable<CgibinFreePublishGetArticleRequest, CgibinFreePublishGetArticleResponse>
    {
        /// <summary>
        /// 获取或设置图文消息的 ArticleId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_id")]
        [System.Text.Json.Serialization.JsonPropertyName("article_id")]
        public string ArticleId { get; set; } = string.Empty;
    }
}
