using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /aibot/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class AIBotResponse : WechatOpenAIPlatformResponse<AIBotResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class BotState
                    {
                        /// <summary>
                        /// 获取或设置机器人配置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                        public string? ErrorMessage { get; set; }

                        /// <summary>
                        /// 获取或设置最后有效时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latest_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("latest_time")]
                        public string? LatestTimeString { get; set; }

                        /// <summary>
                        /// 获取或设置最后有效时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latest_valid")]
                        [System.Text.Json.Serialization.JsonPropertyName("latest_valid")]
                        public bool IsLatestValid { get; set; }
                    }

                    public class Message
                    {
                        /// <summary>
                        /// 获取或设置技能 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ans_node_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ans_node_id")]
                        public int AnswerNodeId { get; set; }

                        /// <summary>
                        /// 获取或设置技能名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ans_node_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("ans_node_name")]
                        public string AnswerNodeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置置信度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("confidence")]
                        [System.Text.Json.Serialization.JsonPropertyName("confidence")]
                        public int Confidence { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置消息类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
                        public string MessageType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置消息内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置消息状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置窗口标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("resp_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("resp_title")]
                        public string? ResponseTitle { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置技能名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ans_node_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ans_node_name")]
                public string AnswerNodeName { get; set; } = default!;

                /// <summary>
                /// 获取或设置回复类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_type")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_type")]
                public string AnswerType { get; set; } = default!;

                /// <summary>
                /// 获取或设置回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer")]
                [System.Text.Json.Serialization.JsonPropertyName("answer")]
                public string Answer { get; set; } = default!;

                /// <summary>
                /// 获取或设置意图标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置回复状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置发起用户。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from_user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("from_user_name")]
                public string FromUserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收机器人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("to_user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("to_user_name")]
                public string ToUserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置机器人状态信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bot_state")]
                [System.Text.Json.Serialization.JsonPropertyName("bot_state")]
                public Types.BotState? BotState { get; set; }

                /// <summary>
                /// 获取或设置详细回答列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg")]
                [System.Text.Json.Serialization.JsonPropertyName("msg")]
                public Types.Message[] MessageList { get; set; } = default!;
            }
        }
    }
}
