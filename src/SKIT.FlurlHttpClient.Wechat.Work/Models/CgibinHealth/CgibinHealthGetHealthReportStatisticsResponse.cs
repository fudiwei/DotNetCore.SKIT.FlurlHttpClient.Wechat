using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/health/get_health_report_stat 接口的响应。</para>
    /// </summary>
    public class CgibinHealthGetHealthReportStatisticsResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置应用使用次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pv")]
        [System.Text.Json.Serialization.JsonPropertyName("pv")]
        public int PV { get; set; }

        /// <summary>
        /// 获取或设置应用使用人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uv")]
        [System.Text.Json.Serialization.JsonPropertyName("uv")]
        public int UV { get; set; }
    }
}
