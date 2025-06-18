namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/menu/get 接口的响应。</para>
    /// </summary>
    public class CgibinMenuGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Button
            {
                /// <summary>
                /// 获取或设置菜单的响应动作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置菜单标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置菜单 KEY 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string? Key { get; set; }

                /// <summary>
                /// 获取或设置网页链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置小程序的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置小程序的页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pagepath")]
                [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                public string? MiniProgramPagePath { get; set; }

                /// <summary>
                /// 获取或设置子菜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_button")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_button")]
                public Button[]? SubButtonList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public Types.Button[] ButtonList { get; set; } = default!;
    }
}
