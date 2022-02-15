namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/get_teacher_customize_health_info 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserGetTeacherCustomizeHealthInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定查询的日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
