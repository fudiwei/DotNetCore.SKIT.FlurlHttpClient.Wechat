namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/statistics/get_start_list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingStatisticsGetStartListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Meeting
            {
                /// <summary>
                /// 获取或设置会议发起者的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议发起时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_list")]
        public Types.Meeting[] MeetingList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
