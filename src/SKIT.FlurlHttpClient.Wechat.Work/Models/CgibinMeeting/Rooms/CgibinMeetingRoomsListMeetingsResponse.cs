namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/list_meetings 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsListMeetingsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Meeting
            {
                /// <summary>
                /// 获取或设置会议 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meetingid")]
                [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
                public string MeetingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置入会码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_code")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_code")]
                public string MeetingCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议主题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject")]
                [System.Text.Json.Serialization.JsonPropertyName("subject")]
                public string Subject { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_type")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_type")]
                public int MeetingType { get; set; }

                /// <summary>
                /// 获取或设置会议状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置会议结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_info_list")]
        public Types.Meeting[] MeetingList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
