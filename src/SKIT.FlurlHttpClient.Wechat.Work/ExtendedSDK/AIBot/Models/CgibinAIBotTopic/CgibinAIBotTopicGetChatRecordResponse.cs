namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/get_chat_record 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicGetChatRecordResponse : WechatWorkAIBotResponse
    {
        public static class Types
        {

            public class Message
            {
                public static class Types
                {
                    public class From
                    {
                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string? Id { get; set; }
                    }

                    public class Text
                    {
                        /// <summary>
                        /// 获取或设置文本内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string? Content { get; set; }
                    }

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置文件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                        public string? FileName { get; set; }
                    }

                    public class File
                    {
                        /// <summary>
                        /// 获取或设置文件 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置文件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// 获取或设置文件大小（单位：字节）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_size")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_size")]
                        public int FileSize { get; set; }
                    }

                    public class Video
                    {
                        /// <summary>
                        /// 获取或设置视频 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置文件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                        public string? FileName { get; set; }
                    }

                    public class Mixed
                    {
                        public static class Types
                        {
                            public class MessageItem
                            {
                                /// <summary>
                                /// 获取或设置消息类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("msgtype")]
                                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                                public string? MessageType { get; set; }

                                /// <summary>
                                /// 获取或设置文本消息信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public Text? Text { get; set; }

                                /// <summary>
                                /// 获取或设置图片消息信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image")]
                                [System.Text.Json.Serialization.JsonPropertyName("image")]
                                public Image? Image { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置混排消息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_item")]
                        public List<Types.MessageItem>? MessageItemList { get; set; }
                    }

                    public class MergedMessage
                    {
                        /// <summary>
                        /// 获取或设置聊天记录列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_item")]
                        public List<Message>? MessageList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtype")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                public string? MessageType { get; set; }

                /// <summary>
                /// 获取或设置消息发送者信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from")]
                [System.Text.Json.Serialization.JsonPropertyName("from")]
                public Types.From? From { get; set; }

                /// <summary>
                /// 获取或设置消息发送时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                public long SendTimestamp { get; set; }

                /// <summary>
                /// 获取或设置文本消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public Types.Text? Text { get; set; }

                /// <summary>
                /// 获取或设置图片消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Types.Image? Image { get; set; }

                /// <summary>
                /// 获取或设置文件消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file")]
                [System.Text.Json.Serialization.JsonPropertyName("file")]
                public Types.File? File { get; set; }

                /// <summary>
                /// 获取或设置视频消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public Types.Video? Video { get; set; }

                /// <summary>
                /// 获取或设置图文消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mixed")]
                [System.Text.Json.Serialization.JsonPropertyName("mixed")]
                public Types.Mixed? Mixed { get; set; }

                /// <summary>
                /// 获取或设置聊天记录消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merged_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("merged_msg")]
                public Types.MergedMessage? MergedMessage { get; set; }
            }

            public class MergedMessage : Message.Types.MergedMessage
            {
            }
        }

        /// <summary>
        /// 获取或设置完整内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string? MessageType { get; set; }

        /// <summary>
        /// 获取或设置聊天记录内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merged_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("merged_msg")]
        public Types.MergedMessage? MergedMessage { get; set; }
    }
}
