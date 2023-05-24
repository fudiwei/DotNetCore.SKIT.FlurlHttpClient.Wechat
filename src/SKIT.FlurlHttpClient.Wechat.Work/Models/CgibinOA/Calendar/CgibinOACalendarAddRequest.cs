using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/calendar/add 接口的请求。</para>
    /// </summary>
    public class CgibinOACalendarAddRequest : WechatWorkRequest
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
                        public string UserId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置日历通知范围成员权限。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("permission")]
                        [System.Text.Json.Serialization.JsonPropertyName("permission")]
                        public int? Permission { get; set; }
                    }

                    public class PublicRange
                    {
                        /// <summary>
                        /// 获取或设置成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userids")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public IList<string>? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyids")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
                        public IList<long>? DepartmentIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置管理员成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admins")]
                [System.Text.Json.Serialization.JsonPropertyName("admins")]
                public IList<string>? AdminUserIdList { get; set; }

                /// <summary>
                /// 获取或设置是否将该日历设置为默认日历。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("set_as_default")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("set_as_default")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// 获取或设置日历标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("summary")]
                [System.Text.Json.Serialization.JsonPropertyName("summary")]
                public string Summary { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置日历颜色（格式：#RRGGBB）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("color")]
                [System.Text.Json.Serialization.JsonPropertyName("color")]
                public string Color { get; set; } = string.Empty;

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_public")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_corp_calendar")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
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
        /// 获取或设置日历信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calendar")]
        [System.Text.Json.Serialization.JsonPropertyName("calendar")]
        public Types.Calendar Calendar { get; set; } = new Types.Calendar();

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
