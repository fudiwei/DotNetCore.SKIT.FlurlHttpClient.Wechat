using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/specapi/create_job 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataSecurityApiCreateJobRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class MessageFilter
            {
                public static class Types
                {
                    public class Message
                    {
                        public static class Types
                        {
                            public class EncryptInfo
                            {
                                /// <summary>
                                /// 获取或设置密钥。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("secret_key")]
                                [System.Text.Json.Serialization.JsonPropertyName("secret_key")]
                                public string SecretKey { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置消息 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msgid")]
                        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                        public string MessageId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置加密信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypt_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypt_info")]
                        public Types.EncryptInfo EncryptInfo { get; set; } = new Types.EncryptInfo();
                    }
                }

                /// <summary>
                /// 获取或设置消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_list")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_list")]
                public IList<Types.Message> MessageList { get; set; } = new List<Types.Message>();
            }
        }

        /// <summary>
        /// 获取或设置消息过滤参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_filter")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_filter")]
        public Types.MessageFilter MessageFilter { get; set; } = new Types.MessageFilter();

        /// <summary>
        /// 获取或设置自定义 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string CustomId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_data")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_data")]
        public string? CustomData { get; set; }
    }
}
