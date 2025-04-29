namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/querybookauth 接口的请求。</para>
    /// </summary>
    public class WxaBookQueryBookAuthRequest : WechatApiRequest, IInferable<WxaBookQueryBookAuthRequest, WxaBookQueryBookAuthResponse>
    {
        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string? BookId { get; set; }

        /// <summary>
        /// 获取或设置是否返回总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_sum")]
        [System.Text.Json.Serialization.JsonPropertyName("is_sum")]
        public bool? IsNeedTotalCount { get; set; }

        /// <summary>
        /// 获取或设置查询类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Limit { get; set; }
    }
}
