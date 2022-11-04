namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/getbucket 接口的请求。</para>
    /// </summary>
    public class ComponentTCBGetBucketRequest : WechatApiRequest, IInferable<ComponentTCBGetBucketRequest, ComponentTCBGetBucketResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置前缀匹配。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prefix")]
        [System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 获取或设置定界符。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delimiter")]
        [System.Text.Json.Serialization.JsonPropertyName("delimiter")]
        public string? Delimiter { get; set; }

        /// <summary>
        /// 获取或设置标志位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marker")]
        [System.Text.Json.Serialization.JsonPropertyName("marker")]
        public string? Marker { get; set; }
    }
}
