namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcloudbaserunenv 接口的响应。</para>
    /// </summary>
    public class ComponentTcbCreateCloudBaseRunEnvironmentResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_id")]
        [System.Text.Json.Serialization.JsonPropertyName("env_id")]
        public string EnvironmentId { get; set; } = default!;
    }
}
