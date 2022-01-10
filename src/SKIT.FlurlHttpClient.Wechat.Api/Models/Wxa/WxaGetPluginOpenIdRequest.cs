namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getpluginopenpid 接口的请求。</para>
    /// </summary>
    public class WxaGetPluginOpenIdRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置插件用户标识凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}
