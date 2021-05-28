using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappidweeklyretaininfo 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdWeeklyRetainInfoResponse : DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse
    {
        /// <summary>
        /// 获取或设置数据的日期（格式：yyyyMMdd-yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_date")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
        public override string RefDateString { get; set; } = default!;
    }
}
