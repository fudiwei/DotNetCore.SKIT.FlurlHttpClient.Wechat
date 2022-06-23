namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/living/get_unwatch_stat_v2 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolLivingGetUnwatchStatisticsV2Response : WechatWorkResponse
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
