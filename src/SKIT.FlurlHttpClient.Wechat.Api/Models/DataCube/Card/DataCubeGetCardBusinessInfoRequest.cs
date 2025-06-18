namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getcardbizuininfo 接口的请求。</para>
    /// </summary>
    public class DataCubeGetCardBusinessInfoRequest : WechatApiRequest, IInferable<DataCubeGetCardBusinessInfoRequest, DataCubeGetCardBusinessInfoResponse>
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

        /// <summary>
        /// 获取或设置卡券来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cond_source")]
        [System.Text.Json.Serialization.JsonPropertyName("cond_source")]
        public int CardSource { get; set; }
    }
}
