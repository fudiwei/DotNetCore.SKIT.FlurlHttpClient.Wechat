namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getarticletotal 接口的响应。</para>
    /// </summary>
    public class DataCubeGetArticleTotalResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置统计的日期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stat_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("stat_date")]
                        public string StatDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置送达人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("target_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("target_user")]
                        public int TargetUserCount { get; set; }

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

                        /// <summary>
                        /// 获取或设置图文页的阅读人数（来自公众号会话）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_session_read_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_session_read_user")]
                        public int InternalPageFromSessionReadUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读次数（来自公众号会话）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_session_read_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_session_read_count")]
                        public int InternalPageFromSessionReadCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读人数（来自历史消息页）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_hist_msg_read_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_hist_msg_read_user")]
                        public int InternalPageFromHistoryReadUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读次数（来自历史消息页）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_hist_msg_read_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_hist_msg_read_count")]
                        public int InternalPageFromHistoryReadCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读人数（来自朋友圈）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_feed_read_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_feed_read_user")]
                        public int InternalPageFromFeedReadUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读次数（来自朋友圈）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_feed_read_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_feed_read_count")]
                        public int InternalPageFromFeedReadCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读人数（来自好友转发）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_friends_read_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_friends_read_user")]
                        public int InternalPageFromFriendsReadUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读次数（来自好友转发）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_friends_read_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_friends_read_count")]
                        public int InternalPageFromFriendsReadCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读人数（来自其他场景）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_other_read_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_other_read_user")]
                        public int InternalPageFromOtherReadUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置图文页的阅读次数（来自其他场景）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("int_page_from_other_read_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("int_page_from_other_read_count")]
                        public int InternalPageFromOtherReadCount { get; set; }

                        /// <summary>
                        /// 获取或设置转发朋友圈的人数（来自公众号会话）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_share_from_session_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_share_from_session_user")]
                        public int FeedShareFromSessionUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置转发朋友圈的次数（来自公众号会话）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_share_from_session_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_share_from_session_cnt")]
                        public int FeedShareFromSessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置转发朋友圈的人数（来自朋友圈）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_share_from_feed_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_share_from_feed_user")]
                        public int FeedShareFromFeedUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置转发朋友圈的次数（来自朋友圈）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_share_from_feed_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_share_from_feed_cnt")]
                        public int FeedShareFromFeedCount { get; set; }

                        /// <summary>
                        /// 获取或设置转发朋友圈的人数（来自其他场景）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_share_from_other_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_share_from_other_user")]
                        public int FeedShareFromOtherUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置转发朋友圈的次数（来自其他场景）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_share_from_other_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_share_from_other_cnt")]
                        public int FeedShareFromOtherCount { get; set; }
                    }
                }

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
                /// 获取或设置数据详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("details")]
                [System.Text.Json.Serialization.JsonPropertyName("details")]
                public Types.Detail[] DetailList { get; set; } = default!;
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
