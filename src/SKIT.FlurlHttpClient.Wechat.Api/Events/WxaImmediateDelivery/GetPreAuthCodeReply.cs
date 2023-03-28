namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.get_pre_auth_code 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onPreAuthCodeGet.html </para>
    /// </summary>
    public class GetPreAuthCodeReply : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("resultcode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("resultmsg")]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// 获取或设置预授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code")]
        public string PreAuthCode { get; set; } = default!;

        public GetPreAuthCodeReply()
        {
            MessageType = "event";
            Event = "get_pre_auth_code";
        }
    }
}
