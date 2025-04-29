namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/getbook 接口的请求。</para>
    /// </summary>
    public class WxaBookGetBookRequest : WechatApiRequest, IInferable<WxaBookGetBookRequest, WxaBookGetBookResponse>
    {
        /// <summary>
        /// 获取或设置是否返回编辑版信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_edited_data")]
        [System.Text.Json.Serialization.JsonPropertyName("need_edited_data")]
        public bool? IsNeedEditedData { get; set; }

        /// <summary>
        /// 获取或设置作品 ID。与字段 <see cref="OriginalId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string? BookId { get; set; }

        /// <summary>
        /// 获取或设置提供方作品唯一标识。与字段 <see cref="BookId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_id")]
        [System.Text.Json.Serialization.JsonPropertyName("original_id")]
        public string? OriginalId { get; set; }
    }
}
