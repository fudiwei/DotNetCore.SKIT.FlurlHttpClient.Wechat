namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/health/get_report_jobids 接口的响应。</para>
    /// </summary>
    public class CgibinHealthGetReportJobIdsResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobids")]
        [System.Text.Json.Serialization.JsonPropertyName("jobids")]
        public List<string>? ReportJobIdList { get; set; }

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ending")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ending")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool IsEnding { get; set; }
    }
}
