namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/queryauth 接口的请求。</para>
    /// </summary>
    public class WxaSecQueryAuthRequest : WechatApiRequest, IInferable<WxaSecQueryAuthRequest, WxaSecQueryAuthResponse>
    {
        /// <summary>
        /// 获取或设置认证任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string TaskId { get; set; } = string.Empty;
    }
}
