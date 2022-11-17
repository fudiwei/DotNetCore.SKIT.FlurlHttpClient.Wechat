using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /aibot/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class AIBotResponse : WechatOpenAIPlatformResponse
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
                public float Confidence { get; set; } = default!;

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

            /// <summary>
            /// 推荐问题
            /// </summary>
            public class Option
            {
                /// <summary>
                /// 推荐的分类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ans_node_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ans_node_name")]
                public string AnswerNodeName { get; set; } = default!;

                /// <summary>
                /// 推荐标准问题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 推荐回答。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer")]
                [System.Text.Json.Serialization.JsonPropertyName("answer")]
                public string Answer { get; set; } = default!;

                /// <summary>
                /// 推荐信息指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confidence")]
                [System.Text.Json.Serialization.JsonPropertyName("confidence")]
                public float Confidence { get; set; } = default!;
            }
        }

        /// <summary>
        /// 技能id。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ans_node_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ans_node_id")]
        public int AnswerNodeId { get; set; }

        /// <summary>
        /// 分类/技能名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ans_node_name")]
        [System.Text.Json.Serialization.JsonPropertyName("ans_node_name")]
        public string AnswerNodeName { get; set; } = default!;

        /// <summary>
        /// 标准问题/意图名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 命中的回答。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer")]
        [System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string Answer { get; set; } = default!;

        /// <summary>
        /// 回答的类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer_type")]
        [System.Text.Json.Serialization.JsonPropertyName("answer_type")]
        public string AnswerType { get; set; } = default!;

        /// <summary>
        /// 回答详细信息(已废弃)。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        [Obsolete("已废弃")]
        public Types.Message[] MessageList { get; set; } = default!;

        /// <summary>
        /// 回答信心指数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confidence")]
        [System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public float Confidence { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("options")]
        [System.Text.Json.Serialization.JsonPropertyName("options")]
        public Types.Option[] Options { get; set; } = default!;

        /// <summary>
        /// 发起 query 的用户,对应签名接口的userid。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("from_user_name")]
        public string FromUserName { get; set; } = default!;

        /// <summary>
        /// 接受 query 的机器人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("to_user_name")]
        public string ToUserName { get; set; } = default!;

        /// <summary>
        /// 机器人回复的状态, 可能的数值：FAQ、NOMATCH、CONTEXT_FAQ、GENERAL_FAQ、FAQ_RECOMMEND。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 消息id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = default!;


        /// <summary>
        /// 用户发送的消息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string Query { get; set; } = default!;
    }
}
