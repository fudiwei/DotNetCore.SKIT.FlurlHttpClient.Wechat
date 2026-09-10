namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/docdata/get_auth_user_list 接口的响应。</para>
    /// </summary>
    public class CgibinCgibinDocDataGetAuthUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AuthUser
            {
                /// <summary>
                /// 获取或设置授权成员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置生效成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_user_list")]
        public Types.AuthUser[] AuthUserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置下一页翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
