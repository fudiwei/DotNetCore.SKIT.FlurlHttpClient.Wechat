namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/get_statistics 接口的请求。</para>
    /// </summary>
    public class CgibinMessageGetStatisticsRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置查询时间类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_type")]
        [System.Text.Json.Serialization.JsonPropertyName("time_type")]
        public int? TimeType { get; set; }
    }
}
