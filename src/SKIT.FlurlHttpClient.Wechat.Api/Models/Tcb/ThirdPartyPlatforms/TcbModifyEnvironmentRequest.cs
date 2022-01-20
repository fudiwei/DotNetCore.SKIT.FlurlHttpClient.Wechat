namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/modifyenv 接口的请求。</para>
    /// </summary>
    public class TcbModifyEnvironmentRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;
    }
}
