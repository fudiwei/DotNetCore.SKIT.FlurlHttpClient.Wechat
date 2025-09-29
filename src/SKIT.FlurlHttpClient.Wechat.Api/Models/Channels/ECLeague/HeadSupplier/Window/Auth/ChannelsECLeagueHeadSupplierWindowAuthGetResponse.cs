namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/windowauth/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowAuthGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AuthInfo
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_wxa_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_wxa_appid")]
                public string MiniProgramAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_wxa_path")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_wxa_path")]
                public string MiniProgramPagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_wxa_username")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_wxa_username")]
                public string MiniProgramName { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_url")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_url")]
                public string AuthUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置达人昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string? TalentNickname { get; set; }

                /// <summary>
                /// 获取或设置达人头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                public string? TalentHeadImageUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public Types.AuthInfo AuthInfo { get; set; } = default!;
    }
}
