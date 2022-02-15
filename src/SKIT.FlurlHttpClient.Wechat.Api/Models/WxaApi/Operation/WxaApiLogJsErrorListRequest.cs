namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/log/jserr_list 接口的请求。</para>
    /// </summary>
    public class WxaApiLogJsErrorListRequest : WechatApiRequest, IMapResponse<WxaApiLogJsErrorListRequest, WxaApiLogJsErrorListResponse>
    {
        /// <summary>
        /// 获取或设置开始日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startTime")]
        [System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime")]
        [System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置错误类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errType")]
        [System.Text.Json.Serialization.JsonPropertyName("errType")]
        public string ErrorType { get; set; } = "0";

        /// <summary>
        /// 获取或设置小程序版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appVersion")]
        [System.Text.Json.Serialization.JsonPropertyName("appVersion")]
        public string AppVersion { get; set; } = "0";

        /// <summary>
        /// 获取或设置发生错误的用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置搜索关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string Keyword { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置排序字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderby")]
        [System.Text.Json.Serialization.JsonPropertyName("orderby")]
        public string OrderBy { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否降序排序。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsDescending { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;
    }
}
