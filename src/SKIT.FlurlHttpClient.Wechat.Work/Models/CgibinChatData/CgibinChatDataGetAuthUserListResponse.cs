namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/get_auth_user_list 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataGetAuthUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AuthUser
            {
                /// <summary>
                /// 获取或设置授权成员的密文 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string OpenUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置生效的版本列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edition_list")]
                [System.Text.Json.Serialization.JsonPropertyName("edition_list")]
                public int[] EditionList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置生效成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_user_list")]
        public Types.AuthUser[] AuthUserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanReadOnlyConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanReadOnlyConverter))]
        public bool HasMore { get; set; }
    }
}
