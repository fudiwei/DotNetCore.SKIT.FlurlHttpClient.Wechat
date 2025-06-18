namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/listmedia 接口的请求。</para>
    /// </summary>
    public class WxaSecVodListMediaRequest : WechatApiRequest, IInferable<WxaSecVodListMediaRequest, WxaSecVodListMediaResponse>
    {
        /// <summary>
        /// 获取或设置所属剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        public long? DramaId { get; set; }

        /// <summary>
        /// 获取或设置视频名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_name")]
        [System.Text.Json.Serialization.JsonPropertyName("media_name")]
        public string? MediaName { get; set; }

        /// <summary>
        /// 获取或设置媒资上传开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置媒资上传结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
