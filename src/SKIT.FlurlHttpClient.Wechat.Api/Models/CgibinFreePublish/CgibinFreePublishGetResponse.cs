using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/freepublish/get 接口的响应。</para>
    /// </summary>
    public class CgibinFreePublishGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ArticleDetail
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置文章索引。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("idx")]
                        [System.Text.Json.Serialization.JsonPropertyName("idx")]
                        public int Index { get; set; }

                        /// <summary>
                        /// 获取或设置文章 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("article_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("article_url")]
                        public string ArticleUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置文章数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置文章列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item")]
                [System.Text.Json.Serialization.JsonPropertyName("item")]
                public Types.Item[] List { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置发布任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_id")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_id")]
        public string PublishId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发布状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_status")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_status")]
        public int PublishStatus { get; set; }

        /// <summary>
        /// 获取或设置图文消息的 ArticleId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_id")]
        [System.Text.Json.Serialization.JsonPropertyName("article_id")]
        public string? ArticleId { get; set; }

        /// <summary>
        /// 获取或设置图文消息的详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("article_detail")]
        public Types.ArticleDetail? ArticleDetail { get; set; }

        /// <summary>
        /// 获取或设置不通过的文章索引列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_idx")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_idx")]
        public int[]? FailedIndexList { get; set; }
    }
}
