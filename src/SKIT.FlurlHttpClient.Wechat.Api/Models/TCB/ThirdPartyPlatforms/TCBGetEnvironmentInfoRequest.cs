namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getenvinfo 接口的请求。</para>
    /// </summary>
    public class TCBGetEnvironmentInfoRequest : WechatApiRequest, IInferable<TCBGetEnvironmentInfoRequest, TCBGetEnvironmentInfoResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;
    }
}
