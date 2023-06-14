namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_invitees 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetInviteesResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Invitee
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置参与者列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invitees")]
        [System.Text.Json.Serialization.JsonPropertyName("invitees")]
        public Types.Invitee[] InviteeList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
