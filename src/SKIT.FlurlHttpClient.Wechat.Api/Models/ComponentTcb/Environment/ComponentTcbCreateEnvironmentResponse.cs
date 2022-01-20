namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createenv 接口的响应。</para>
    /// </summary>
    public class ComponentTcbCreateEnvironmentResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置后付费订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranid")]
        [System.Text.Json.Serialization.JsonPropertyName("tranid")]
        public string TransactionId { get; set; } = default!;
    }
}
