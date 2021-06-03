using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/book 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomBookResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_id")]
        public string MeetingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置关联日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string? ScheduleId { get; set; }
    }
}
