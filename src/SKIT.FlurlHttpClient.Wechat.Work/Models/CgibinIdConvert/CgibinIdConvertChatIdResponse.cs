namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/chatid 接口的响应。</para>
    /// </summary>
    public class CgibinIdConvertChatIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置升级前的群聊 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
                public string GroupChatId { get; set; } = default!;

                /// <summary>
                /// 获取或设置升级后的群聊 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("new_chat_id")]
                public string NewGroupChatId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的群聊 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_chat_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_chat_id_list")]
        public string[]? InvalidGroupChatIdList { get; set; } = default!;
    }
}
