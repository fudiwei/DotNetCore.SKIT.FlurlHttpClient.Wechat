namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/open/get_download_url 接口的响应。</para>
    /// </summary>
    public class ChannelsECOpenGetDownloadUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置文件下载链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置链接到期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public long ExpireTimestamp { get; set; }
    }
}
