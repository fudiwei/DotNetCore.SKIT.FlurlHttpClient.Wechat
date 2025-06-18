namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/finderlive/get_finder_live_leads_data 接口的请求。</para>
    /// </summary>
    public class ChannelsFinderLiveGetFinderLeadsDataListRequest : WechatApiRequest, IInferable<ChannelsFinderLiveGetFinderLeadsDataListRequest, ChannelsFinderLiveGetFinderLeadsDataListResponse>
    {
        /// <summary>
        /// 获取或设置查询范围的开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询范围的结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置来源类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_type")]
        [System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public int? SourceType { get; set; }
    }
}
