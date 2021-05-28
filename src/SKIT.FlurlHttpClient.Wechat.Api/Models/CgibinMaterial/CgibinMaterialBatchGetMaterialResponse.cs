using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/batchget_material 接口的响应。</para>
    /// </summary>
    public class CgibinMaterialBatchGetMaterialResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Material
            {
                public static class Types
                {
                    public class Content
                    {
                        public static class Types
                        {
                            public class Article : CgibinMaterialGetMaterialAsNewsResponse.Types.Article
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置图文消息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("news_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("news_item")]
                        public Types.Article[]? ArticleList { get; set; }

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
                /// 获取或设置媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置素材名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置素材 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置图文消息信息。
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
            }
        }

        /// <summary>
        /// 获取或设置素材数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置本次调用获取的素材数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_count")]
        [System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置图文消息素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Material[] MaterialList { get; set; } = default!;
    }
}
