using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/analyze_task_add 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataAnalyzeTaskAddRequest : WechatWorkRequest
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
        /// 获取或设置任务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("analyze_task")]
        [System.Text.Json.Serialization.JsonPropertyName("analyze_task")]
        public int TaskType { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string? JobId { get; set; }

        /// <summary>
        /// 获取或设置消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_list")]
        public IList<Types.Message> MessageList { get; set; } = new List<Types.Message>();
    }
}
