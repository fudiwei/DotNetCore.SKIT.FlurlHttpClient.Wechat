namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/account/fastregister 接口的响应。</para>
    /// </summary>
    public class CgibinAccountFastRegisterResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置新创建的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置新创建小程序的授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_code")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_code")]
        public string AuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否小程序微信认证成功。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_wx_verify_succ")]
        [System.Text.Json.Serialization.JsonPropertyName("is_wx_verify_succ")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualBooleanConverter))]
        public bool IsVerifySuccessful { get; set; }

        /// <summary>
        /// 获取或设置是否和公众号关联成功。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_link_succ")]
        [System.Text.Json.Serialization.JsonPropertyName("is_link_succ")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualBooleanConverter))]
        public bool IsLinkSuccessful { get; set; }
    }
}
