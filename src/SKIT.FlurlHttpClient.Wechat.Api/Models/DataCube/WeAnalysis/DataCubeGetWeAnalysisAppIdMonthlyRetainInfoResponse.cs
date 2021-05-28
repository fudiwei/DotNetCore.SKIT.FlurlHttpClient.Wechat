using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappidmonthlyretaininfo 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdMonthlyRetainInfoResponse : DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse
    {
        /// <summary>
        /// 获取或设置数据的日期（格式：yyyyMM）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_date")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
        public override string RefDateString { get; set; } = default!;
    }
}
