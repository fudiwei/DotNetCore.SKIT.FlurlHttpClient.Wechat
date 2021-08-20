using System;
using System.Collections.Generic;

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
        public string[] ReportJobIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ending")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ending")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsEnding { get; set; }
    }
}
