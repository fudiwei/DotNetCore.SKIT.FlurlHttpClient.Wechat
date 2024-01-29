namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/living/get_unwatch_stat 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolLivingGetUnwatchStatisticsResponse : WechatWorkResponse
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
                        public string? StudentUserId { get; set; }

                        /// <summary>
                        /// 获取或设置家长账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
                        public string? ParentUserId { get; set; }

                        /// <summary>
                        /// 获取或设置学生所在的部门 ID（即班级）列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyids")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
                        public long[] DepartmentIdList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置学生列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("students")]
                [System.Text.Json.Serialization.JsonPropertyName("students")]
                public Types.Student[] StudentList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置统计信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stat_info")]
        [System.Text.Json.Serialization.JsonPropertyName("stat_info")]
        public Types.Statistics Statistics { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ending")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ending")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsEnding { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
