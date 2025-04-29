namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/commkf/cosupload 接口的响应。</para>
    /// </summary>
    public class ChannelsECCommonKfCosUploadResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cos_url")]
        [System.Text.Json.Serialization.JsonPropertyName("cos_url")]
        public string CosUrl { get; set; } = default!;
    }
}
