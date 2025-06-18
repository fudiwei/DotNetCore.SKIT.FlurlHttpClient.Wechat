namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/list_devices 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsListDevicesRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议室名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_room_name")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_room_name")]
        public string? MeetingRoomName { get; set; }

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
