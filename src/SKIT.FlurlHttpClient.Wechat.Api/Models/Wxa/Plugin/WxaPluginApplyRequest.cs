namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/plugin?action=apply 接口的请求。</para>
    /// </summary>
    public class WxaPluginApplyRequest : WechatApiRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "apply";

        /// <summary>
        /// 获取或设置插件 Appid。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plugin_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("plugin_appid")]
        public string PluginAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请使用理由。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = string.Empty;
    }
}
