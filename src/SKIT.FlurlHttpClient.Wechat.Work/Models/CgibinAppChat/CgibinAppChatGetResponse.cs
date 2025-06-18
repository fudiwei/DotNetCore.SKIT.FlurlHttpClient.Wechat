namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/appchat/get 接口的响应。</para>
    /// </summary>
    public class CgibinAppChatGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AppChat
            {
                /// <summary>
                /// 获取或设置群聊 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chatid")]
                [System.Text.Json.Serialization.JsonPropertyName("chatid")]
                public string ChatId { get; set; } = default!;

                /// <summary>
                /// 获取或设置群聊名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置群主 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner")]
                [System.Text.Json.Serialization.JsonPropertyName("owner")]
                public string OwnerUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置群成员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userlist")]
                [System.Text.Json.Serialization.JsonPropertyName("userlist")]
                public string[] MemberUserIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置群聊信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_info")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_info")]
        public Types.AppChat AppChat { get; set; } = default!;
    }
}
