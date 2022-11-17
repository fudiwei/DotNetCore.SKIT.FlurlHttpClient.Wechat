namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/contact/search 接口的请求。</para>
    /// </summary>
    public class CgibinServiceContactSearchRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corpid")]
        public string AuthorizerCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置搜索关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_word")]
        [System.Text.Json.Serialization.JsonPropertyName("query_word")]
        public string QueryWord { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置查询类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_type")]
        public int? QueryType { get; set; }

        /// <summary>
        /// 获取或设置查询范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_range")]
        [System.Text.Json.Serialization.JsonPropertyName("query_range")]
        public int? QueryRange { get; set; }

        /// <summary>
        /// 获取或设置精确匹配字段类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full_match_field")]
        [System.Text.Json.Serialization.JsonPropertyName("full_match_field")]
        public int? FullMatchField { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
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
