namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/custom/typing 接口的请求。</para>
    /// </summary>
    public class CgibinMessageCustomTypingRequest : WechatApiRequest, IInferable<CgibinMessageCustomTypingRequest, CgibinMessageCustomTypingResponse>
    {
        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置输入状态。
        /// <para>默认值："Typing"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("command")]
        [System.Text.Json.Serialization.JsonPropertyName("command")]
        public string Command { get; set; } = "Typing";
    }
}
