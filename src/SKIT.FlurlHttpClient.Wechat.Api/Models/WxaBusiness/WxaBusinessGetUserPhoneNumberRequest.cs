namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getuserphonenumber 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGetUserPhoneNumberRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置手机号获取凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}
