namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/devplugin?action=dev_delete 接口的请求。</para>
    /// </summary>
    public class WxaDevPluginDevDeleteRequest : WechatApiRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "dev_delete";
    }
}
