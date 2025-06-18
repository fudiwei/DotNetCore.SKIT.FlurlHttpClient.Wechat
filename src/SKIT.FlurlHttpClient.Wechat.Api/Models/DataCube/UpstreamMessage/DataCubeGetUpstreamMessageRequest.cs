namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getupstreammsg 接口的请求。</para>
    /// </summary>
    public class DataCubeGetUpstreamMessageRequest : WechatApiRequest, IInferable<DataCubeGetUpstreamMessageRequest, DataCubeGetUpstreamMessageResponse>
    {
        /// <summary>
        /// 获取或设置获取数据的起始日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_date")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
        public string BeginDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置获取数据的结束日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = string.Empty;
    }
}
