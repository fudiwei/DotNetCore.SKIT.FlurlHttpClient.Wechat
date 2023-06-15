namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/book 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsBookResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MeetingRoom
            {
                /// <summary>
                /// 获取或设置会议室 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_id")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_id")]
                public string MeetingRoomId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议室名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_name")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_name")]
                public string MeetingRoomName { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议室地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_location")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_location")]
                public string MeetingRoomLocation { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置会议室列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_room_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_room_list")]
        public Types.MeetingRoom[] MeetingRoomList { get; set; } = default!;
    }
}
