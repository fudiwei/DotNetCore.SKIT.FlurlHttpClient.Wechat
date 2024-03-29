﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/add_attendees 接口的请求。</para>
    /// </summary>
    public class CgibinOAScheduleAddAttendeesRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Attendee : CgibinOAScheduleAddRequest.Types.Schedule.Types.Attendee
            {
            }
        }

        /// <summary>
        /// 获取或设置日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string ScheduleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要添加的日程参与者列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public IList<Types.Attendee> AttendeeList { get; set; } = new List<Types.Attendee>();
    }
}
