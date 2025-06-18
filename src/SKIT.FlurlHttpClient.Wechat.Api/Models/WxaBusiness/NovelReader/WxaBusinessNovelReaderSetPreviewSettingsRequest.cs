using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/novelreader/setpreviewsetting 接口的请求。</para>
    /// </summary>
    public class WxaBusinessNovelReaderSetPreviewSettingsRequest : WechatApiRequest, IInferable<WxaBusinessNovelReaderSetPreviewSettingsRequest, WxaBusinessNovelReaderSetPreviewSettingsResponse>
    {
        public static class Types
        {
            public class Settings
            {
                public static class Types
                {
                    public class Chapter
                    {
                        /// <summary>
                        /// 获取或设置章节索引。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chapter_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("chapter_index")]
                        public int ChapterIndex { get; set; }

                        /// <summary>
                        /// 获取或设置章节字数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("words")]
                        [System.Text.Json.Serialization.JsonPropertyName("words")]
                        public int? WordCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置作品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                public string BookId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置默认预览字数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_words")]
                [System.Text.Json.Serialization.JsonPropertyName("default_words")]
                public int DefaultWordCount { get; set; }

                /// <summary>
                /// 获取或设置章节列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_setting")]
                public IList<Types.Chapter>? ChapterList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置预览设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("setting")]
        [System.Text.Json.Serialization.JsonPropertyName("setting")]
        public Types.Settings Settings { get; set; } = new Types.Settings();
    }
}
