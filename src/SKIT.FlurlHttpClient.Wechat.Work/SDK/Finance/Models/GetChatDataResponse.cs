namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models
{
    public class GetChatDataResponse : WechatWorkFinanceResponse
    {
        public static class Types
        {
            public class ChatData
            {
                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seq")]
                [System.Text.Json.Serialization.JsonPropertyName("seq")]
                public long NextCursor { get; set; }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息加解密公钥版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publickey_ver")]
                [System.Text.Json.Serialization.JsonPropertyName("publickey_ver")]
                public int PublicKeyVersion { get; set; }

                /// <summary>
                /// 获取或设置经过加密的随机密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_random_key")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_random_key")]
                public string EncryptedRandomKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置经过加密的聊天内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_chat_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_chat_msg")]
                public string EncryptedChatMessage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置聊天记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatdata")]
        [System.Text.Json.Serialization.JsonPropertyName("chatdata")]
        public Types.ChatData[] ChatDataList { get; set; } = default!;
    }
}
