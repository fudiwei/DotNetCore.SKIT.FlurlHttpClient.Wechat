namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/unmatched/class/detail 接口的请求。</para>
    /// </summary>
    public class UnmatchedClassDetailRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置查询日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置话术 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_id")]
        [System.Text.Json.Serialization.JsonPropertyName("class_id")]
        public long ClassId { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// <para>默认值：desc</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort")]
        [System.Text.Json.Serialization.JsonPropertyName("sort")]
        public string SortType { get; set; } = "desc";

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        [System.Text.Json.Serialization.JsonPropertyName("page_no")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
