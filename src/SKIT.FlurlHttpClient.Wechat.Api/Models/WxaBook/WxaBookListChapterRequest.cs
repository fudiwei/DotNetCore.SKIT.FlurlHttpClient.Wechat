namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/listchapter 接口的请求。</para>
    /// </summary>
    public class WxaBookListChapterRequest : WechatApiRequest, IInferable<WxaBookListChapterRequest, WxaBookListChapterResponse>
    {
        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否返回编辑版信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_edited_data")]
        [System.Text.Json.Serialization.JsonPropertyName("need_edited_data")]
        public bool? IsNeedEditedData { get; set; }

        /// <summary>
        /// 获取或设置分卷下标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volume_index")]
        [System.Text.Json.Serialization.JsonPropertyName("volume_index")]
        public int? VolumeIndex { get; set; }

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
