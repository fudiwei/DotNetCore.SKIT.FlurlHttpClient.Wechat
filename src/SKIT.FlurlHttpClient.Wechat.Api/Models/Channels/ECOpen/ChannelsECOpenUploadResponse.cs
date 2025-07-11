namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/open/upload 接口的响应。</para>
    /// </summary>
    public class ChannelsECOpenUploadResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = default!;
    }
}
