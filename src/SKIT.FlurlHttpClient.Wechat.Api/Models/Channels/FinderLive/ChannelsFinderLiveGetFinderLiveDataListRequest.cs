namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/finderlive/get_finder_live_data_list 接口的请求。</para>
    /// </summary>
    public class ChannelsFinderLiveGetFinderLiveDataListRequest : WechatApiRequest, IInferable<ChannelsFinderLiveGetFinderLiveDataListRequest, ChannelsFinderLiveGetFinderLiveDataListResponse>
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
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? Cursor { get; set; }
    }
}
