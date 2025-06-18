namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/list 接口的请求。</para>
    /// </summary>
    public class CgibinReportGridListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定上级网格 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_id")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_id")]
        public string? ParentGridId { get; set; }
    }
}
