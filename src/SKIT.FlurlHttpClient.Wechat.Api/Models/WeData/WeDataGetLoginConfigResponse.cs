namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_get_login_config 接口的响应。</para>
    /// </summary>
    public class WeDataGetLoginConfigResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AppInfo
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("component_appid")]
        public string ComponentAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务商昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("component_nickname")]
        public string ComponentNickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置反查地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recheck_url")]
        [System.Text.Json.Serialization.JsonPropertyName("recheck_url")]
        public string RecheckUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置关联小程序列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appinfo")]
        [System.Text.Json.Serialization.JsonPropertyName("appinfo")]
        public Types.AppInfo[] AssociatedAppList { get; set; } = default!;
    }
}
