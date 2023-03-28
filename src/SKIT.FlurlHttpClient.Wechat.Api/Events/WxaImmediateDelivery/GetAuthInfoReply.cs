namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.get_auth_info 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onPreAuthCodeGet.html </para>
    /// </summary>
    public class GetAuthInfoReply : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable
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
        /// 获取或设置配送公司分配的 AppKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appkey")]
        [System.Text.Json.Serialization.JsonPropertyName("appkey")]
        public string AppKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置帐号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public int AccountType { get; set; }

        /// <summary>
        /// 获取或设置帐号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string Account { get; set; } = default!;

        public GetAuthInfoReply()
        {
            MessageType = "event";
            Event = "get_auth_info";
        }
    }
}
