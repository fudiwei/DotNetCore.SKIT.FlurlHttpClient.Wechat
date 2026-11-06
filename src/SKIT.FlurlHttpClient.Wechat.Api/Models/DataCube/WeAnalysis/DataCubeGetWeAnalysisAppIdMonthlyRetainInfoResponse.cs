namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappidmonthlyretaininfo 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdMonthlyRetainInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置数据的日期（格式：yyyyMM）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_date")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
        public string? RefDateString { get; set; }

        /// <summary>
        /// 获取或设置新增用户留存数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visit_uv_new")]
        [System.Text.Json.Serialization.JsonPropertyName("visit_uv_new")]
        public List<Types.Data>? NewVisitUVDataList { get; set; }

        /// <summary>
        /// 获取或设置活跃用户留存数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visit_uv")]
        [System.Text.Json.Serialization.JsonPropertyName("visit_uv")]
        public List<Types.Data>? VisitUVDataList { get; set; }
    }
}
