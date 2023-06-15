namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/list_meetings 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsListMeetingsRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议室 ID。与字段 <see cref="RoomsId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_room_id")]
        public string? MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置 Rooms ID。与字段 <see cref="MeetingRoomId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rooms_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rooms_id")]
        public string? RoomsId { get; set; }

        /// <summary>
        /// 获取或设置查询起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
