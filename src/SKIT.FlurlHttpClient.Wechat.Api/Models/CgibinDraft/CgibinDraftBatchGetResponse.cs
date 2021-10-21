using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/draft/batchget 接口的响应。</para>
    /// </summary>
    public class CgibinDraftBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Draft
            {
                public static class Types
                {
                    public class Content
                    {
                        public static class Types
                        {
                            public class Article : CgibinDraftGetResponse.Types.Article
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置草稿图文消息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("news_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("news_item")]
                        public Types.Article[] ArticleList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置草稿的 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置草稿内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.Content? Content { get; set; }

                /// <summary>
                /// 获取或设置修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置草稿列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Draft[] DraftList { get; set; } = default!;

        /// <summary>
        /// 获取或设置本次草稿数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_count")]
        [System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int DraftCount { get; set; } = default!;

        /// <summary>
        /// 获取或设置草稿总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; } = default!;
    }
}
