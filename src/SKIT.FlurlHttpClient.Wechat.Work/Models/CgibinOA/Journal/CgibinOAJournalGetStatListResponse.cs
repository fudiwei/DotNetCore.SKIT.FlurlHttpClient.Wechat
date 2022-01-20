namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/get_stat_list 接口的响应。</para>
    /// </summary>
    public class CgibinOAJournalGetStatListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;
                    }

                    public class Department
                    {
                        /// <summary>
                        /// 获取或设置部门 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_partyid")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_partyid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int DepartmentId { get; set; }
                    }

                    public class Tag
                    {
                        /// <summary>
                        /// 获取或设置标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_tagid")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_tagid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int TagId { get; set; }
                    }

                    public class Leader
                    {
                        /// <summary>
                        /// 获取或设置上级级别。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level")]
                        [System.Text.Json.Serialization.JsonPropertyName("level")]
                        public int Level { get; set; }
                    }

                    public class Journal
                    {
                        /// <summary>
                        /// 获取或设置汇报 UUID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("journaluuid")]
                        [System.Text.Json.Serialization.JsonPropertyName("journaluuid")]
                        public string JournalId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置汇报时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reporttime")]
                        [System.Text.Json.Serialization.JsonPropertyName("reporttime")]
                        public long? ReportTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否迟交。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flag")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("flag")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsLate { get; set; }
                    }

                    public class ReporterRange
                    {
                        /// <summary>
                        /// 获取或设置汇报人成员列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public User[] UserList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置汇报人部门列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("party_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("party_list")]
                        public Department[] DepartmentList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置汇报人标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
                        public Tag[] TagList { get; set; } = default!;
                    }

                    public class ReceiverRange
                    {
                        /// <summary>
                        /// 获取或设置接收人成员列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public User[] UserList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置接收人标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
                        public Tag[] TagList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置接收人标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("leader_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("leader_list")]
                        public Leader[] LearderList { get; set; } = default!;
                    }

                    public class Reporter
                    {
                        /// <summary>
                        /// 获取或设置汇报人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user")]
                        [System.Text.Json.Serialization.JsonPropertyName("user")]
                        public User User { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置汇报列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("itemlist")]
                        [System.Text.Json.Serialization.JsonPropertyName("itemlist")]
                        public Journal[] JournalList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置汇报表单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报表单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_name")]
                [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                public string TemplateName { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报人员范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_range")]
                [System.Text.Json.Serialization.JsonPropertyName("report_range")]
                public Types.ReporterRange ReporterRange { get; set; } = default!;

                /// <summary>
                /// 获取或设置白名单范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("white_range")]
                [System.Text.Json.Serialization.JsonPropertyName("white_range")]
                public Types.ReporterRange ReporterWhiteListRange { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收人员范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receivers")]
                [System.Text.Json.Serialization.JsonPropertyName("receivers")]
                public Types.ReceiverRange ReceiverRange { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_list")]
                [System.Text.Json.Serialization.JsonPropertyName("report_list")]
                public Types.Reporter[] ReporterList { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unreport_list")]
                [System.Text.Json.Serialization.JsonPropertyName("unreport_list")]
                public Types.Reporter[] UnreportedReporterList { get; set; } = default!;

                /// <summary>
                /// 获取或设置周期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cycle_begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("cycle_begin_time")]
                public long CycleBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置周期结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cycle_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("cycle_end_time")]
                public long CycleEndTimestamp { get; set; } = default!;

                /// <summary>
                /// 获取或设置统计开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stat_begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("stat_begin_time")]
                public long StatisticsBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置统计结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stat_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("stat_end_time")]
                public long StatisticsEndTimestamp { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_type")]
                [System.Text.Json.Serialization.JsonPropertyName("report_type")]
                public int ReportType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置汇报统计列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("stat_list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
