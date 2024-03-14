namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/groupchat/get 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataGroupChatGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置成员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("memberid")]
                [System.Text.Json.Serialization.JsonPropertyName("memberid")]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置入群时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jointime")]
                [System.Text.Json.Serialization.JsonPropertyName("jointime")]
                public long JoinTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置群成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("members")]
        [System.Text.Json.Serialization.JsonPropertyName("members")]
        public Types.Member[] MemberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建者的密文 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator")]
        [System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string CreatorOpenUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("room_create_time")]
        public long CreateTimestamp { get; set; }
    }
}
