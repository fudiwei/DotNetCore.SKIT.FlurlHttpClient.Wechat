namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/sitecode/get_report_answer 接口的请求。</para>
    /// </summary>
    public class CgibinReportSiteCodeGetReportAnswerRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置场所码 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("siteid")]
        [System.Text.Json.Serialization.JsonPropertyName("siteid")]
        public string SiteCodeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }
    }
}
