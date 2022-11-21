using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /aibot/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class AIBotResponse : WechatOpenAIResponse
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
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
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
                /// 获取或设置是否是列表选择。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list_options")]
                [System.Text.Json.Serialization.JsonPropertyName("list_options")]
                public bool IsListOptions { get; set; }

                /// <summary>
                /// 获取或设置是否仅选择。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("take_options_only")]
                [System.Text.Json.Serialization.JsonPropertyName("take_options_only")]
                public bool IsTakeOptionsOnly { get; set; }

                /// <summary>
                /// 获取或设置当前事件。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                public string? Event { get; set; }

                /// <summary>
                /// 获取或设置调试信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("debug_info")]
                [System.Text.Json.Serialization.JsonPropertyName("debug_info")]
                public string? DebugInfo { get; set; }

                /// <summary>
                /// 获取或设置窗口标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resp_title")]
                [System.Text.Json.Serialization.JsonPropertyName("resp_title")]
                public string? ResponseTitle { get; set; }

                /// <summary>
                /// 获取或设置场景状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_status")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_status")]
                public string? SceneStatus { get; set; }

                /// <summary>
                /// 获取或设置会话 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("session_id")]
                [System.Text.Json.Serialization.JsonPropertyName("session_id")]
                public string? SessionId { get; set; }
            }

            public class Option
            {
                /// <summary>
                /// 获取或设置推荐分类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ans_node_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ans_node_name")]
                public string AnswerNodeName { get; set; } = default!;

                /// <summary>
                /// 获取或设置推荐标准问题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置推荐回答。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer")]
                [System.Text.Json.Serialization.JsonPropertyName("answer")]
                public string Answer { get; set; } = default!;

                /// <summary>
                /// 获取或设置推荐信息指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confidence")]
                [System.Text.Json.Serialization.JsonPropertyName("confidence")]
                public double Confidence { get; set; }
            }

            public class Slot
            {
                /// <summary>
                /// 获取或设置槽位确认状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confirm_status")]
                [System.Text.Json.Serialization.JsonPropertyName("confirm_status")]
                public string ConfirmStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置开始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start")]
                [System.Text.Json.Serialization.JsonPropertyName("start")]
                public int Start { get; set; }

                /// <summary>
                /// 获取或设置结束位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end")]
                [System.Text.Json.Serialization.JsonPropertyName("end")]
                public int End { get; set; }

                /// <summary>
                /// 获取或设置槽位名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slot_name")]
                [System.Text.Json.Serialization.JsonPropertyName("slot_name")]
                public string SlotName { get; set; } = default!;

                /// <summary>
                /// 获取或设置槽位值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slot_value")]
                [System.Text.Json.Serialization.JsonPropertyName("slot_value")]
                public string SlotValue { get; set; } = default!;

                /// <summary>
                /// 获取或设置词典类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entity_type")]
                [System.Text.Json.Serialization.JsonPropertyName("entity_type")]
                public string? EntityType { get; set; }

                /// <summary>
                /// 获取或设置归一化的值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("norm")]
                [System.Text.Json.Serialization.JsonPropertyName("norm")]
                public string? Norm { get; set; }

                /// <summary>
                /// 获取或设置归一化的值详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("norm_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("norm_detail")]
                public string? NormDetail { get; set; }

                /// <summary>
                /// 获取或设置回复的意图名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ans_node_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ans_node_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int AnswerNodeId { get; set; }

        /// <summary>
        /// 获取或设置技能名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ans_node_name")]
        [System.Text.Json.Serialization.JsonPropertyName("ans_node_name")]
        public string AnswerNodeName { get; set; } = default!;

        /// <summary>
        /// 获取或设置标准问题或意图名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置命中的回答。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer")]
        [System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string Answer { get; set; } = default!;

        /// <summary>
        /// 获取或设置回答显示状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer_open")]
        [System.Text.Json.Serialization.JsonPropertyName("answer_open")]
        public int? AnswerOpenStatus { get; set; }

        /// <summary>
        /// 获取或设置回答的类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer_type")]
        [System.Text.Json.Serialization.JsonPropertyName("answer_type")]
        public string AnswerType { get; set; } = default!;

        /// <summary>
        /// 获取或设置回答信心指数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confidence")]
        [System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// 获取或设置发起查询的用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("from_user_name")]
        public string FromUserName { get; set; } = default!;

        /// <summary>
        /// 获取或设置接受查询的机器人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("to_user_name")]
        public string ToUserName { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户发送的消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string QueryString { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string MessageType { get; set; } = default!;

        /// <summary>
        /// 获取或设置回答详细信息。
        /// </summary>
        [Obsolete("相关接口或字段于 2022-04-15 下线。")]
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public Types.Message[]? MessageList { get; set; }

        /// <summary>
        /// 获取或设置机器人回复的状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置当前事件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_id")]
        [System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 获取或设置请求标识符。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rid")]
        [System.Text.Json.Serialization.JsonPropertyName("rid")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 获取或设置当前对话会话状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dialog_session_status")]
        [System.Text.Json.Serialization.JsonPropertyName("dialog_session_status")]
        public string? DialogSessionStatus { get; set; }

        /// <summary>
        /// 获取或设置当前对话状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dialog_status")]
        [System.Text.Json.Serialization.JsonPropertyName("dialog_status")]
        public string? DialogStatus { get; set; }

        /// <summary>
        /// 获取或设置意图确认状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_confirm_status")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_confirm_status")]
        public string? IntentConfirmStatus { get; set; }

        /// <summary>
        /// 获取或设置场景状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_status")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_status")]
        public string? SceneStatus { get; set; }

        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public string? SkillId { get; set; }

        /// <summary>
        /// 获取或设置技能名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_name")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_name")]
        public string? SkillName { get; set; }

        /// <summary>
        /// 获取或设置机器人回复的状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_default_answer")]
        [System.Text.Json.Serialization.JsonPropertyName("is_default_answer")]
        public bool IsDefaultAnswer { get; set; }

        /// <summary>
        /// 获取或设置是否是列表选择。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list_options")]
        [System.Text.Json.Serialization.JsonPropertyName("list_options")]
        public bool IsListOptions { get; set; }

        /// <summary>
        /// 获取或设置是否仅选择。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("take_options_only")]
        [System.Text.Json.Serialization.JsonPropertyName("take_options_only")]
        public bool IsTakeOptionsOnly { get; set; }

        /// <summary>
        /// 获取或设置推荐问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("options")]
        [System.Text.Json.Serialization.JsonPropertyName("options")]
        public Types.Option[]? OptionList { get; set; }

        /// <summary>
        /// 获取或设置槽位列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slots_info")]
        [System.Text.Json.Serialization.JsonPropertyName("slots_info")]
        public Types.Slot[]? SlotList { get; set; }
    }
}
