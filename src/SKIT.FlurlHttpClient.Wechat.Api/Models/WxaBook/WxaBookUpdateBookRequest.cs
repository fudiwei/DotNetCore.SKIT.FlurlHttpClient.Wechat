using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/updatebook 接口的请求。</para>
    /// </summary>
    public class WxaBookUpdateBookRequest : WechatApiRequest, IInferable<WxaBookUpdateBookRequest, WxaBookUpdateBookResponse>
    {
        public static class Types
        {
            public class Volume
            {
                /// <summary>
                /// 获取或设置分卷名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("volume_title")]
                [System.Text.Json.Serialization.JsonPropertyName("volume_title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分卷起始章节下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_index")]
                [System.Text.Json.Serialization.JsonPropertyName("start_index")]
                public int StartIndex { get; set; }

                /// <summary>
                /// 获取或设置分卷截止章节下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_index")]
                [System.Text.Json.Serialization.JsonPropertyName("end_index")]
                public int EndIndex { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置作品名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置作品简介。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intro")]
        [System.Text.Json.Serialization.JsonPropertyName("intro")]
        public string? Introduction { get; set; }

        /// <summary>
        /// 获取或设置封面图 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_media_id")]
        public string? CoverMediaId { get; set; }

        /// <summary>
        /// 获取或设置作者名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("author")]
        [System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// 获取或设置一级类型 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("first_category_id")]
        public int? FirstCategoryId { get; set; }

        /// <summary>
        /// 获取或设置二级类型 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("second_category_id")]
        public int? SecondCategoryId { get; set; }

        /// <summary>
        /// 获取或设置三级类型 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("third_category_id")]
        public int? ThirdCategoryId { get; set; }

        /// <summary>
        /// 获取或设置完结状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complete_status")]
        [System.Text.Json.Serialization.JsonPropertyName("complete_status")]
        public int? CompleteStatus { get; set; }

        /// <summary>
        /// 获取或设置提供方作品唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_id")]
        [System.Text.Json.Serialization.JsonPropertyName("original_id")]
        public string? OriginalId { get; set; }

        /// <summary>
        /// 获取或设置章节 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_id_list")]
        public IList<string>? ChapterIdList { get; set; }

        /// <summary>
        /// 获取或设置是否需要分卷。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_volume")]
        [System.Text.Json.Serialization.JsonPropertyName("need_volume")]
        public bool? IsNeedVolume { get; set; }

        /// <summary>
        /// 获取或设置分卷列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volume_list")]
        [System.Text.Json.Serialization.JsonPropertyName("volume_list")]
        public IList<Types.Volume>? VolumeList { get; set; }

        /// <summary>
        /// 获取或设置章节排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter_order_method")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_order_method")]
        public int? ChapterOrderMethod { get; set; }

        /// <summary>
        /// 获取或设置自定义信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_info")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_info")]
        public string? CustomInfo { get; set; }

        /// <summary>
        /// 获取或设置是否更新题材关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("update_keyword")]
        public bool? IsUpdateKeyword { get; set; }

        /// <summary>
        /// 获取或设置题材关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_list")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
        public IList<string>? KeywordList { get; set; }

        /// <summary>
        /// 获取或设置精彩片段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awesome_paragraph")]
        [System.Text.Json.Serialization.JsonPropertyName("awesome_paragraph")]
        public string? AwesomeParagraph { get; set; }
    }
}
