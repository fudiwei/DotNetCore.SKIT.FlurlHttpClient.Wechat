namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/cancel_call 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsCancelCallRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class MRA : CgibinMeetingRoomsCallRequest.Types.MRA
            {
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置呼叫 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invite_id")]
        [System.Text.Json.Serialization.JsonPropertyName("invite_id")]
        public string InviteId { get; set; } = string.Empty;

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
