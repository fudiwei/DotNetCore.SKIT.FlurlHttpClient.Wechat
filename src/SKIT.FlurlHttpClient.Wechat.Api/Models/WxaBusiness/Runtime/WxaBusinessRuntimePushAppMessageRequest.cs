namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/runtime/pushappmsg 接口的请求。</para>
    /// </summary>
    public class WxaBusinessRuntimePushAppMessageRequest : WechatApiRequest, IInferable<WxaBusinessRuntimePushAppMessageRequest, WxaBusinessRuntimePushAppMessageResponse>
    {
        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置产品中文名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("push_token")]
        [System.Text.Json.Serialization.JsonPropertyName("push_token")]
        public string PushToken { get; set; } = string.Empty;
    }
}
