namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/call 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsCallRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class MRA
            {
                /// <summary>
                /// 获取或设置信令协议。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("protocol")]
                [System.Text.Json.Serialization.JsonPropertyName("protocol")]
                public int Protocol { get; set; }

                /// <summary>
                /// 获取或设置信令。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dial_string")]
                [System.Text.Json.Serialization.JsonPropertyName("dial_string")]
                public string DialogString { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议室 ID。与字段 <see cref="MRA"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_room_id")]
        public string? MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置 MRA 信息。与字段 <see cref="MeetingRoomId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mra_address")]
        [System.Text.Json.Serialization.JsonPropertyName("mra_address")]
        public Types.MRA? MRA { get; set; }
    }
}
