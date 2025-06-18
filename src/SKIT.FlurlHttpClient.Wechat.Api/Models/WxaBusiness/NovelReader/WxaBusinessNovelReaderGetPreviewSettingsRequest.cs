namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/novelreader/getpreviewsetting 接口的请求。</para>
    /// </summary>
    public class WxaBusinessNovelReaderGetPreviewSettingsRequest : WechatApiRequest, IInferable<WxaBusinessNovelReaderGetPreviewSettingsRequest, WxaBusinessNovelReaderGetPreviewSettingsResponse>
    {
        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;
    }
}
