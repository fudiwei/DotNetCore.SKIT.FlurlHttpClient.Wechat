namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/sec/vod/getauthorizeapps 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetAuthorizeAppsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Object
            {
                /// 获取或设置被授权方小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorized_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("authorized_appid")]
                public string AuthorizedAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorized_time")]
                [System.Text.Json.Serialization.JsonPropertyName("authorized_time")]
                public long AuthorizeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置授权到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authz_expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("authz_expire_time")]
                public long? ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("objects")]
        [System.Text.Json.Serialization.JsonPropertyName("objects")]
        public Types.Object[] ObjectList { get; set; } = default!;
    }
}
