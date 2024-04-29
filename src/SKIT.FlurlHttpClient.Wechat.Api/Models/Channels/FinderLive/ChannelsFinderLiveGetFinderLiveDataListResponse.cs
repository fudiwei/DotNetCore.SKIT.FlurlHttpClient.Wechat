namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/finderlive/get_finder_live_data_list 接口的响应。</para>
    /// </summary>
    public class ChannelsFinderLiveGetFinderLiveDataListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LiveData
            {
                /// <summary>
                /// 获取或设置直播唯一 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("export_id")]
                public string ExportId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开播时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("live_start_time")]
                public long LiveStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置直播时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_duration_in_seconds")]
                [System.Text.Json.Serialization.JsonPropertyName("live_duration_in_seconds")]
                public int LiveDuration { get; set; }

                /// <summary>
                /// 获取或设置观看人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_audience_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_audience_count")]
                public int TotalAudienceCount { get; set; }

                /// <summary>
                /// 获取或设置喝彩次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_cheer_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_cheer_count")]
                public int TotalCheerCount { get; set; }

                /// <summary>
                /// 获取或设置分享次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("forward_count")]
                [System.Text.Json.Serialization.JsonPropertyName("forward_count")]
                public int ForwardCount { get; set; }

                /// <summary>
                /// 获取或设置评论条数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_comment_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_comment_count")]
                public int CommentCount { get; set; }

                /// <summary>
                /// 获取或设置人均观看时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audiences_avg_seconds")]
                [System.Text.Json.Serialization.JsonPropertyName("audiences_avg_seconds")]
                public int AudiencesAverageSeconds { get; set; }

                /// <summary>
                /// 获取或设置最高在线人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_online_count")]
                [System.Text.Json.Serialization.JsonPropertyName("max_online_count")]
                public int MaxOnlineCount { get; set; }

                /// <summary>
                /// 获取或设置新增粉丝数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_follow_count")]
                [System.Text.Json.Serialization.JsonPropertyName("new_follow_count")]
                public int NewFollowCount { get; set; }

                /// <summary>
                /// 获取或设置公众号新增粉丝数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_follow_count_biz")]
                [System.Text.Json.Serialization.JsonPropertyName("new_follow_count_biz")]
                public int NewFollowBusinessCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置直播数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.LiveData[] LiveDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? NextCursor { get; set; }
    }
}
