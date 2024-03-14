namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/search_chat 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataSearchChatRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置搜索词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_word")]
        [System.Text.Json.Serialization.JsonPropertyName("query_word")]
        public string QueryWord { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
