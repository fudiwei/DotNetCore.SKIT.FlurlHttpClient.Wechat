namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/sync_msg 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataSyncMessageResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Message
            {
                public static class Types
                {
                    public class Sender
                    {
                        /// <summary>
                        /// 获取或设置身份类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;
                    }

                    public class Receiver : Sender
                    {
                    }

                    public class ServiceEncryptInfo
                    {
                        /// <summary>
                        /// 获取或设置加密后的密钥。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypted_secret_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypted_secret_key")]
                        public string EncryptedSecretKey { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置公钥版本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("public_key_ver")]
                        [System.Text.Json.Serialization.JsonPropertyName("public_key_ver")]
                        public int PublicKeyVersion { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtype")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                public int MessageType { get; set; }

                /// <summary>
                /// 获取或设置发送者信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender")]
                [System.Text.Json.Serialization.JsonPropertyName("sender")]
                public Types.Sender Sender { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_list")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_list")]
                public Types.Receiver[]? ReceiverList { get; set; }

                /// <summary>
                /// 获取或设置群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chatid")]
                [System.Text.Json.Serialization.JsonPropertyName("chatid")]
                public string? GroupChatId { get; set; }

                /// <summary>
                /// 获取或设置发送时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                public long SendTimestamp { get; set; }

                /// <summary>
                /// 获取或设置加密信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_encrypt_info")]
                [System.Text.Json.Serialization.JsonPropertyName("service_encrypt_info")]
                public Types.ServiceEncryptInfo ServiceEncryptInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_list")]
        public Types.Message[] MessageList { get; set; } = default!;

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
