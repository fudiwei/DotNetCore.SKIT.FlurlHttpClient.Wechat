namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/freepublish/getarticle 接口的响应。</para>
    /// </summary>
    public class CgibinFreePublishGetArticleResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Article : CgibinDraftGetResponse.Types.Article
            {
                /// <summary>
                /// 获取或设置是否已删除。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_deleted")]
                [System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
                public bool IsDeleted { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图文消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("news_item")]
        [System.Text.Json.Serialization.JsonPropertyName("news_item")]
        public Types.Article[] ArticleList { get; set; } = default!;
    }
}
