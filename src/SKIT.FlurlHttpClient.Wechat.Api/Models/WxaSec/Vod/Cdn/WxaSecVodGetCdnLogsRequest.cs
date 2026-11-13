namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getcdnlogs 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetCdnLogsRequest : WechatApiRequest, IInferable<WxaSecVodGetCdnLogsRequest, WxaSecVodGetCdnLogsResponse>
    {
        /// <summary>
        /// 获取或设置起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_type")]
        public int? QueryType { get; set; }
    }
}
