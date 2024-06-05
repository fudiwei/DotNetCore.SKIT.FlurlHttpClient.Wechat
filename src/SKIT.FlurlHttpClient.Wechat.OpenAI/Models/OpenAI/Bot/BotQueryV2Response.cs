namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/query 接口的响应。</para>
    /// </summary>
    public class BotQueryV2Response : WechatOpenAIResponse<BotQueryV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : WechatOpenAIResponseData
            {
                public static class Types
                {
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
                        public decimal Confidence { get; set; }
                    }

                    public class Slot
                    {
                        /// <summary>
                        /// 获取或设置槽位名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置槽位值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置归一化的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("norm")]
                        [System.Text.Json.Serialization.JsonPropertyName("norm")]
                        public string? NormalizedValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置回答的类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_type")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_type")]
                public string AnswerType { get; set; } = default!;

                /// <summary>
                /// 获取或设置命中的回答。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer")]
                [System.Text.Json.Serialization.JsonPropertyName("answer")]
                public string Answer { get; set; } = default!;

                /// <summary>
                /// 获取或设置机器人回复状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置技能名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skill_name")]
                [System.Text.Json.Serialization.JsonPropertyName("skill_name")]
                public string? SkillName { get; set; }

                /// <summary>
                /// 获取或设置意图名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intent_name")]
                [System.Text.Json.Serialization.JsonPropertyName("intent_name")]
                public string? IntentName { get; set; }

                /// <summary>
                /// 获取或设置推荐问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("options")]
                [System.Text.Json.Serialization.JsonPropertyName("options")]
                public Types.Option[]? OptionList { get; set; }

                /// <summary>
                /// 获取或设置槽位数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slots")]
                [System.Text.Json.Serialization.JsonPropertyName("slots")]
                public Types.Slot[]? SlotList { get; set; }
            }
        }
    }
}
