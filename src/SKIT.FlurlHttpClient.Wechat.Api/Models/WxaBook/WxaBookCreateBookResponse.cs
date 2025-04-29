namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/createbook 接口的响应。</para>
    /// </summary>
    public class WxaBookCreateBookResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = default!;
    }
}
