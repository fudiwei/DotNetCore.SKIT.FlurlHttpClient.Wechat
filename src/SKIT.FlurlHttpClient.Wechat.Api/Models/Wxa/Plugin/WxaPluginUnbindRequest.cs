using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/plugin?action=unbind 接口的请求。</para>
    /// </summary>
    public class WxaPluginUnbindRequest : WechatApiRequest, IMapResponse<WxaPluginUnbindRequest, WxaPluginUnbindResponse>
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "unbind";

        /// <summary>
        /// 获取或设置插件 Appid。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plugin_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("plugin_appid")]
        public string PluginAppId { get; set; } = string.Empty;
    }
}
