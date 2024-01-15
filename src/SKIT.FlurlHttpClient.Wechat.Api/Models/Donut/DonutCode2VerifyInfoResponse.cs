namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /donut/code2verifyinfo 接口的响应。</para>
    /// </summary>
    public class DonutCode2VerifyInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LoginInfo
            {
                /// <summary>
                /// 获取或设置登录方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置登录时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("login_time")]
                [System.Text.Json.Serialization.JsonPropertyName("login_time")]
                public long LoginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置微信 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }
            }

            public class UserInfo
            {
                public static class Types
                {
                    public class OpenAppUserInfo
                    {
                        /// <summary>
                        /// 获取或设置微信 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的 UnionId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unionid")]
                        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                        public string? UnionId { get; set; }

                        /// <summary>
                        /// 获取或设置用户头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headimgurl")]
                        [System.Text.Json.Serialization.JsonPropertyName("headimgurl")]
                        public string? HeadImageUrl { get; set; }

                        /// <summary>
                        /// 获取或设置用户昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string? Nickname { get; set; }
                    }

                    public class MiniProgramUserInfo
                    {
                        /// <summary>
                        /// 获取或设置微信 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的 UnionId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unionid")]
                        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                        public string? UnionId { get; set; }
                    }

                    public class PhoneUserInfo
                    {
                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        public string MobileNumber { get; set; } = default!;
                    }

                    public class AppleUserInfo
                    {
                        /// <summary>
                        /// 获取或设置苹果应用 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bundleid")]
                        [System.Text.Json.Serialization.JsonPropertyName("bundleid")]
                        public string BundleId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置苹果用户 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apple_user_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("apple_user_id")]
                        public string AppleUserId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置多端用户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信移动应用的用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openapp_info")]
                [System.Text.Json.Serialization.JsonPropertyName("openapp_info")]
                public Types.OpenAppUserInfo? OpenAppUserInfo { get; set; }

                /// <summary>
                /// 获取或设置微信小程序的用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("miniprogram_info")]
                [System.Text.Json.Serialization.JsonPropertyName("miniprogram_info")]
                public Types.MiniProgramUserInfo? MiniProgramUserInfo { get; set; }

                /// <summary>
                /// 获取或设置手机号用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_info")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_info")]
                public Types.PhoneUserInfo? PhoneUserInfo { get; set; }

                /// <summary>
                /// 获取或设置苹果用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apple_info")]
                [System.Text.Json.Serialization.JsonPropertyName("apple_info")]
                public Types.AppleUserInfo? AppleUserInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置登录信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_info")]
        [System.Text.Json.Serialization.JsonPropertyName("login_info")]
        public Types.LoginInfo LoginInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public Types.UserInfo UserInfo { get; set; } = default!;
    }
}
