using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/book 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomBookRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置会议主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject")]
        [System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// 获取或设置预定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置预定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置预定者的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booker")]
        [System.Text.Json.Serialization.JsonPropertyName("booker")]
        public string BookerUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置参与人的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public IList<string>? AttendeeUserIdList { get; set; }
    }
}
