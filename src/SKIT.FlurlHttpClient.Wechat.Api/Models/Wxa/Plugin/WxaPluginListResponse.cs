namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/plugin?action=list 接口的响应。</para>
    /// </summary>
    public class WxaPluginListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Plugin
            {
                /// <summary>
                /// 获取或设置插件 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置插件状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置插件昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置插件头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimgurl")]
                [System.Text.Json.Serialization.JsonPropertyName("headimgurl")]
                public string HeadImageUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置插件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plugin_list")]
        [System.Text.Json.Serialization.JsonPropertyName("plugin_list")]
        public Types.Plugin[] PluginList { get; set; } = default!;
    }
}
