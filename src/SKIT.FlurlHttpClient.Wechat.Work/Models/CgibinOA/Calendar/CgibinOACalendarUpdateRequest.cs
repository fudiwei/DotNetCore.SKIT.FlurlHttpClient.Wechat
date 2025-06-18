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

                    public class PublicRange : CgibinOACalendarAddRequest.Types.Calendar.Types.PublicRange
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
                /// 获取或设置管理员成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admins")]
                [System.Text.Json.Serialization.JsonPropertyName("admins")]
                public IList<string>? AdminUserIdList { get; set; }

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
                /// 获取或设置是否是公共日历。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_public")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_public")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool? IsPublicCalendar { get; set; }

                /// <summary>
                /// 获取或设置公开范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("public_range")]
                [System.Text.Json.Serialization.JsonPropertyName("public_range")]
                public Types.PublicRange? PublicRange { get; set; }

                /// <summary>
                /// 获取或设置是否是全员日历。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_corp_calendar")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_corp_calendar")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool? IsCorpCalendar { get; set; }

                /// <summary>
                /// 获取或设置日历共享者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shares")]
                [System.Text.Json.Serialization.JsonPropertyName("shares")]
                public IList<Types.Sharer>? SharerList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置是否不更新可订阅范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_public_range")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("skip_public_range")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsSkipPublicRange { get; set; }

        /// <summary>
        /// 获取或设置日历信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar")]
        public Types.Calendar Calendar { get; set; } = new Types.Calendar();
    }
}
