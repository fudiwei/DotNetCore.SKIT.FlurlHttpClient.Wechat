namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /gethotquerydetail/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class GetHotQueryDetailRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pageNo")]
        [System.Text.Json.Serialization.JsonPropertyName("pageNo")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pageSize")]
        [System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置命中类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchType")]
        [System.Text.Json.Serialization.JsonPropertyName("matchType")]
        public int? MatchType { get; set; }

        /// <summary>
        /// 获取或设置问题类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cluesType")]
        [System.Text.Json.Serialization.JsonPropertyName("cluesType")]
        public int? ClueType { get; set; }

        /// <summary>
        /// 获取或设置报告类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportType")]
        [System.Text.Json.Serialization.JsonPropertyName("reportType")]
        public int? ReportType { get; set; }

        /// <summary>
        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置聚类结果类别 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clusterId")]
        [System.Text.Json.Serialization.JsonPropertyName("clusterId")]
        public string ClusterId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置聚类结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hotQuesCluster")]
        [System.Text.Json.Serialization.JsonPropertyName("hotQuesCluster")]
        public string? HotQuestionCluster { get; set; }
    }
}
