using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [GET] /v1/bot/test 接口的响应。</para>
    /// </summary>
    public class BotTestResponse : WechatOpenAIThirdPartyResponse<BotTestResponse.Types.Data>
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
                        [Newtonsoft.Json.JsonProperty("last_effective_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_effective_time")]
                        public string? LastEffectiveTimeString { get; set; }
                    }
                }

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
                /// 获取或设置机器人状态信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bot_state")]
                [System.Text.Json.Serialization.JsonPropertyName("bot_state")]
                public Types.BotState? BotState { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CreateTimestamp { get; set; }
            }
        }
    }
}
