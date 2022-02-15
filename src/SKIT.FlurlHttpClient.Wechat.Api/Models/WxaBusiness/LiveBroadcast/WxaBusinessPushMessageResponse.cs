namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/push_message 接口的响应。</para>
    /// </summary>
    public class WxaBusinessPushMessageResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置群发消息标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message_id")]
        [System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string MessageId { get; set; } = default!;
    }
}
