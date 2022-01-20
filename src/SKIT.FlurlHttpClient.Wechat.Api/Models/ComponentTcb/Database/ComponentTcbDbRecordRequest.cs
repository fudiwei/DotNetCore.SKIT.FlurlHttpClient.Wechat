namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbrecord 接口的请求。</para>
    /// </summary>
    public class ComponentTcbDbRecordRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置数据库操作语句。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? QueryString { get; set; }
    }
}
