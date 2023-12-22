namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_user_notify 接口的请求。</para>
    /// </summary>
    public class WxaGetUserNotifyRequest : WechatApiRequest, IInferable<WxaGetUserNotifyRequest, WxaGetUserNotifyResponse>
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡片类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_type")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_type")]
        public int NotifyType { get; set; }

        /// <summary>
        /// 获取或设置动态更新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_code")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_code")]
        public string NotifyCode { get; set; } = string.Empty;
    }
}
