namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/get_config 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsGetConfigRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_room_id")]
        public string MeetingRoomId { get; set; } = string.Empty;
    }
}
