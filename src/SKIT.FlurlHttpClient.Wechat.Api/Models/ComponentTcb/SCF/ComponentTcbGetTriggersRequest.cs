namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/gettriggers 接口的请求。</para>
    /// </summary>
    public class ComponentTcbGetTriggersRequest : WechatApiRequest, IInferable<ComponentTcbGetTriggersRequest, ComponentTcbGetTriggersResponse>
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
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funcname")]
        [System.Text.Json.Serialization.JsonPropertyName("funcname")]
        public string FunctionName { get; set; } = string.Empty;
    }
}
