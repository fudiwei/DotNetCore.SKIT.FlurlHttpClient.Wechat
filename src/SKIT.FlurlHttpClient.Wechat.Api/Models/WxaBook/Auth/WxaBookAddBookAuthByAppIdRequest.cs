namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/addbookauthbyappid 接口的请求。</para>
    /// </summary>
    public class WxaBookAddBookAuthByAppIdRequest : WechatApiRequest, IInferable<WxaBookAddBookAuthByAppIdRequest, WxaBookAddBookAuthByAppIdResponse>
    {
        public static class Types
        {
            public class Authorization
            {
                /// <summary>
                /// 获取或设置被授权账号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grantee_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("grantee_appid")]
                public string? GranteeAppId { get; set; }

                /// <summary>
                /// 获取或设置授权到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long? ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infos")]
        [System.Text.Json.Serialization.JsonPropertyName("infos")]
        public List<Types.Authorization>? AuthorizationList { get; set; }
    }
}
