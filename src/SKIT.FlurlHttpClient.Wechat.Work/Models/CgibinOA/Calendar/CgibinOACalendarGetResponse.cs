namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/calendar/get 接口的响应。</para>
    /// </summary>
    public class CgibinOACalendarGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Calendar
            {
                public static class Types
                {
                    public class Sharer
                    {
                        /// <summary>
                        /// 获取或设置共享者成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置共享者对日历是否只读权限。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("readonly")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("readonly")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsReadonly { get; set; }
                    }

                    public class PublicRange
                    {
                        /// <summary>
                        /// 获取或设置成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userids")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public string[]? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyids")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
                        public long[]? DepartmentIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置日历 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cal_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cal_id")]
                public string CalendarId { get; set; } = default!;

                /// <summary>
                /// 获取或设置组织者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organizer")]
                [System.Text.Json.Serialization.JsonPropertyName("organizer")]
                public string OrganizerUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置组织者对日历是否只读权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("readonly")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("readonly")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsReadonly { get; set; }

                /// <summary>
                /// 获取或设置日历标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("summary")]
                [System.Text.Json.Serialization.JsonPropertyName("summary")]
                public string Summary { get; set; } = default!;

                /// <summary>
                /// 获取或设置日历颜色（格式：#RRGGBB）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("color")]
                [System.Text.Json.Serialization.JsonPropertyName("color")]
                public string Color { get; set; } = default!;

                /// <summary>
                /// 获取或设置日历描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否是公共日历。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_public")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_public")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsPublicCalendar { get; set; }

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_corp_calendar")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsCorpCalendar { get; set; }

                /// <summary>
                /// 获取或设置日历共享者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shares")]
                [System.Text.Json.Serialization.JsonPropertyName("shares")]
                public Types.Sharer[]? SharerList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置日历列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar_list")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar_list")]
        public Types.Calendar[] CalendarList { get; set; } = default!;
    }
}
