namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getpluginopenpid 接口的响应。</para>
    /// </summary>
    public class WxaGetPluginOpenIdResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置插件用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openpid")]
        [System.Text.Json.Serialization.JsonPropertyName("openpid")]
        public string PluginOpenId { get; set; } = default!;
    }
}
