namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/info/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECVipUserInfoAddRequest : WechatApiRequest, IInferable<ChannelsECVipUserInfoAddRequest, ChannelsECVipUserInfoAddResponse>
    {
        public static class Types
        {
            public class UserInfo
            {
                /// <summary>
                /// 获取或设置用户会员身份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                public string Identity { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用户会员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outer_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("outer_userid")]
                public string? OutUserId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户操作的会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_id")]
        [System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string SessionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.UserInfo UserInfo { get; set; } = new Types.UserInfo();
    }
}
