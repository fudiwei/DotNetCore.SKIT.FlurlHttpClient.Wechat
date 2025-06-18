namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/list_member_auth 接口的响应。</para>
    /// </summary>
    public class CgibinUserListMemberAuthResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MemberAuth
            {
                /// <summary>
                /// 获取或设置第三方成员唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string OepnUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置成员授权列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_auth_list")]
        [System.Text.Json.Serialization.JsonPropertyName("member_auth_list")]
        public Types.MemberAuth[] MemberAuthList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
