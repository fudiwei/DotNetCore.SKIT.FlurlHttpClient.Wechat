namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/health/get_health_report_stat 接口的请求。</para>
    /// </summary>
    public class CgibinHealthGetHealthReportStatisticsRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定查询的日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty;
    }
}
