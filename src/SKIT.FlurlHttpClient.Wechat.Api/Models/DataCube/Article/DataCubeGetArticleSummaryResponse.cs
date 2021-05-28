using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getarticlesummary 接口的响应。</para>
    /// </summary>
    public class DataCubeGetArticleSummaryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息 ID 及消息次序索引。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string MessageIdAndIndex { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文消息的标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文页的阅读人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("int_page_read_user")]
                [System.Text.Json.Serialization.JsonPropertyName("int_page_read_user")]
                public int InternalPageReadUserCount { get; set; }

                /// <summary>
                /// 获取或设置图文页的阅读次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("int_page_read_count")]
                [System.Text.Json.Serialization.JsonPropertyName("int_page_read_count")]
                public int InternalPageReadCount { get; set; }

                /// <summary>
                /// 获取或设置原文页的阅读人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ori_page_read_user")]
                [System.Text.Json.Serialization.JsonPropertyName("ori_page_read_user")]
                public int OriginalPageReadUserCount { get; set; }

                /// <summary>
                /// 获取或设置原文页的阅读次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ori_page_read_count")]
                [System.Text.Json.Serialization.JsonPropertyName("ori_page_read_count")]
                public int OriginalPageReadCount { get; set; }

                /// <summary>
                /// 获取或设置分享的人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_user")]
                [System.Text.Json.Serialization.JsonPropertyName("share_user")]
                public int ShareUserCount { get; set; }

                /// <summary>
                /// 获取或设置分享的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_count")]
                [System.Text.Json.Serialization.JsonPropertyName("share_count")]
                public int ShareCount { get; set; }

                /// <summary>
                /// 获取或设置收藏的人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_to_fav_user")]
                [System.Text.Json.Serialization.JsonPropertyName("add_to_fav_user")]
                public int AddToFavoritesUserCount { get; set; }

                /// <summary>
                /// 获取或设置收藏的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_to_fav_count")]
                [System.Text.Json.Serialization.JsonPropertyName("add_to_fav_count")]
                public int AddToFavoritesCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
