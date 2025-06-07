namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/mpverifybetaweapp 接口的请求。</para>
    /// </summary>
    public class WxaMpVerifyBetaWeappRequest : WechatApiRequest, IInferable<WxaMpVerifyBetaWeappRequest, WxaMpVerifyBetaWeappResponse>
    {
        /// <summary>
        /// 获取或设置公众号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_appid")]
        public string MediaPlatformAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公众号管理员授权成功后推送的票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket")]
        public string IsSameAdmin { get; set; } = string.Empty;
    }
}
