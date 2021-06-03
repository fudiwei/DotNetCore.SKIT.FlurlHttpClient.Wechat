using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/get_by_calendar 接口的响应。</para>
    /// </summary>
    public class CgibinOAScheduleGetByCalendarResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Schedule : CgibinOAScheduleGetResponse.Types.Schedule
            {
                /// <summary>
                /// 获取或设置日程序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sequence")]
                [System.Text.Json.Serialization.JsonPropertyName("sequence")]
                public int Sequence { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置日程列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_list")]
        public Types.Schedule[] ScheduleList { get; set; } = default!;
    }
}
