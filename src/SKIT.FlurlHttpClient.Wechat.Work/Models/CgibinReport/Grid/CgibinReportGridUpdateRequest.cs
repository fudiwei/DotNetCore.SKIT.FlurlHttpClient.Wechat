namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/update 接口的请求。</para>
    /// </summary>
    public class CgibinReportGridUpdateRequest : CgibinReportGridAddRequest
    {
        /// <summary>
        /// 获取或设置网格 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_id")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_id")]
        public string GridId { get; set; } = string.Empty;
    }
}
