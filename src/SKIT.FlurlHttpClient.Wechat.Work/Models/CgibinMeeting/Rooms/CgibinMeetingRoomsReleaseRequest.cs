using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/release 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsReleaseRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议室 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_room_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_room_id_list")]
        public IList<string> MeetingRoomIdList { get; set; } = new List<string>();
    }
}
