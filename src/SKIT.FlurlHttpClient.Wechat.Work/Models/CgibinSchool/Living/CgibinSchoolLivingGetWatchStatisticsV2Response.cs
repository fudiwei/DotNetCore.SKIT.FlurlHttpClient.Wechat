namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/living/get_watch_stat_v2 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolLivingGetWatchStatisticsV2Response : WechatWorkResponse
    {
        public static class Types
        {
            public class Statistics
            {
                public static class Types
                {
                    public class Student
                    {
                        /// <summary>
                        /// 获取或设置学生账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("student_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                        public string StudentUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置学生所在的部门 ID（即班级）列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyids")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
                        public long[] DepartmentIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("watch_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("watch_time")]
                        public int WatchTime { get; set; }

                        /// <summary>
                        /// 获取或设置首次进入直播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enter_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("enter_time")]
                        public long EnterTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置最后离开直播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("leave_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("leave_time")]
                        public long LeaveTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否评论。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_comment")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_comment")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsComment { get; set; }
                    }

                    public class Parent : Student
                    {
                        /// <summary>
                        /// 获取或设置家长账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
                        public string ParentUserId { get; set; } = default!;
                    }

                    public class Visitor
                    {
                        /// <summary>
                        /// 获取或设置微信昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string? Nickname { get; set; }

                        /// <summary>
                        /// 获取或设置观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("watch_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("watch_time")]
                        public int WatchTime { get; set; }

                        /// <summary>
                        /// 获取或设置首次进入直播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enter_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("enter_time")]
                        public long EnterTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置最后离开直播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("leave_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("leave_time")]
                        public long LeaveTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否评论。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_comment")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_comment")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsComment { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置学生列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("students")]
                [System.Text.Json.Serialization.JsonPropertyName("students")]
                public Types.Student[] StudentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置家长列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parents")]
                [System.Text.Json.Serialization.JsonPropertyName("parents")]
                public Types.Parent[] ParentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置观众列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visitors")]
                [System.Text.Json.Serialization.JsonPropertyName("visitors")]
                public Types.Visitor[] VisitorList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置统计信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stat_info")]
        [System.Text.Json.Serialization.JsonPropertyName("stat_info")]
        public Types.Statistics Statistics { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
