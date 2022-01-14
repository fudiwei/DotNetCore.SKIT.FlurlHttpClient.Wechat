namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/createenvandresource 接口的请求。</para>
    /// </summary>
    public class TcbCreateEnvironmentAndResourceRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        [System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string Alias { get; set; } = string.Empty;
    }
}
