using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/setcheckinschedulist 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinSetCheckinScheduleListRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Schedule
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置排班日期（格式：d）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("day")]
                [System.Text.Json.Serialization.JsonPropertyName("day")]
                public int Day { get; set; }

                /// <summary>
                /// 获取或设置排班 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
                public int ScheduleId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupid")]
        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
        public int GroupId { get; set; }

        /// <summary>
        /// 获取或设置排班年月（格式：yyyyMM）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yearmonth")]
        [System.Text.Json.Serialization.JsonPropertyName("yearmonth")]
        public int YearAndMonth { get; set; }

        /// <summary>
        /// 获取或设置排版列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public IList<Types.Schedule> ScheduleList { get; set; } = new List<Types.Schedule>();
    }
}
