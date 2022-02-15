namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappiddailyretaininfo 接口的请求。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdDailyRetainInfoRequest : WechatApiRequest, IMapResponse<DataCubeGetWeAnalysisAppIdDailyRetainInfoRequest, DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse>
    {
        /// <summary>
        /// 获取或设置开始时间字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_date")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
        public string BeginDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束时间字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = string.Empty;
    }
}
