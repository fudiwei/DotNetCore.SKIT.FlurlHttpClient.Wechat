namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/work/get 接口的响应。</para>
    /// </summary>
    public class CustomServiceWorkGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entityName")]
        [System.Text.Json.Serialization.JsonPropertyName("entityName")]
        public string? EntityName { get; set; }

        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string? CorpId { get; set; }

        /// <summary>
        /// 获取或设置绑定时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bindTime")]
        [System.Text.Json.Serialization.JsonPropertyName("bindTime")]
        public long? BindTimestamp { get; set; }
    }
}
