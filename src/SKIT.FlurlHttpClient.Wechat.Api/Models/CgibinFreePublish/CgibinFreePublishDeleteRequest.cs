using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/freepublish/delete 接口的请求。</para>
    /// </summary>
    public class CgibinFreePublishDeleteRequest : WechatApiRequest, IMapResponse<CgibinFreePublishDeleteRequest, CgibinFreePublishDeleteResponse>
    {
        /// <summary>
        /// 获取或设置图文消息的 ArticleId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_id")]
        [System.Text.Json.Serialization.JsonPropertyName("article_id")]
        public string ArticleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要删除的文章在图文消息中的索引。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index")]
        [System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }
    }
}
