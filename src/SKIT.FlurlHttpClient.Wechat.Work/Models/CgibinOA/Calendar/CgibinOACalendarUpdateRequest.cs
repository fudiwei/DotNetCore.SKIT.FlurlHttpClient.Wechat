using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/calendar/update 接口的请求。</para>
    /// </summary>
    public class CgibinOACalendarUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Calendar
            {
                public static class Types
                {
                    public class Sharer : CgibinOACalendarAddRequest.Types.Calendar.Types.Sharer
                    {
                    }
                }

                /// <summary>
                /// 获取或设置日历 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cal_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cal_id")]
                public string CalendarId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置组织者对日历是否只读权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("readonly")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("readonly")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsReadonly { get; set; }

                /// <summary>
                /// 获取或设置日历标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("summary")]
                [System.Text.Json.Serialization.JsonPropertyName("summary")]
                public string? Summary { get; set; }

                /// <summary>
                /// 获取或设置日历颜色（格式：#RRGGBB）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("color")]
                [System.Text.Json.Serialization.JsonPropertyName("color")]
                public string? Color { get; set; }

                /// <summary>
                /// 获取或设置日历描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置日历共享者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shares")]
                [System.Text.Json.Serialization.JsonPropertyName("shares")]
                public IList<Types.Sharer>? SharerList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置日历信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar")]
        public Types.Calendar Calendar { get; set; } = new Types.Calendar();
    }
}
