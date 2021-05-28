using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/get_material 接口的响应。</para>
    /// </summary>
    public class CgibinMaterialGetMaterialAsNewsResponse : CgibinMaterialGetMaterialResponse
    {
        public static class Types
        {
            public class Article
            {
                /// <summary>
                /// 获取或设置图文消息缩略图媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                public string ThumbnailMediaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息作者。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("author")]
                [System.Text.Json.Serialization.JsonPropertyName("author")]
                public string Author { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息摘要。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("digest")]
                [System.Text.Json.Serialization.JsonPropertyName("digest")]
                public string Digest { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息阅读原文 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_source_url")]
                [System.Text.Json.Serialization.JsonPropertyName("content_source_url")]
                public string ContentSourceUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息页面的内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息页面的 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否显示封面。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_cover_pic")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("show_cover_pic")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                public bool IsShowCover { get; set; }

                /// <summary>
                /// 获取或设置是否打开评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_open_comment")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("need_open_comment")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsOpenComment { get; set; }

                /// <summary>
                /// 获取或设置是否粉丝才可评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("only_fans_can_comment")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("only_fans_can_comment")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsOnlyFansCanComment { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图文消息素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("news_item")]
        [System.Text.Json.Serialization.JsonPropertyName("news_item")]
        public Types.Article[] ArticleList { get; set; } = default!;
    }
}
