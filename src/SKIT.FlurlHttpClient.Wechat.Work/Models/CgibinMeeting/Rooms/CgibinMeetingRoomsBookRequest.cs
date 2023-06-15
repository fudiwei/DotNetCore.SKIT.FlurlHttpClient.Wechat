using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/book 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRoomsBookRequest : WechatWorkRequest
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

        /// <summary>
        /// 获取或设置是否显示会议主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject_visible")]
        [System.Text.Json.Serialization.JsonPropertyName("subject_visible")]
        public bool? IsSubjectVisible { get; set; }
    }
}
