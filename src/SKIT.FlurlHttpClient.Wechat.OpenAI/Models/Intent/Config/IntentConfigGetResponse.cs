using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/config/get 接口的响应。</para>
    /// </summary>
    public class IntentConfigGetResponse : WechatOpenAIResponse<IntentConfigGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Slot
                    {
                        /// <summary>
                        /// 获取或设置语义槽名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置词典名称列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dicts")]
                        [System.Text.Json.Serialization.JsonPropertyName("dicts")]
                        public string[] DictionaryNameList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否追问。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keep_ask")]
                        [System.Text.Json.Serialization.JsonPropertyName("keep_ask")]
                        public bool IsKeepAsk { get; set; }

                        /// <summary>
                        /// 获取或设置追问话术列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ask_content")]
                        [System.Text.Json.Serialization.JsonPropertyName("ask_content")]
                        public string[]? AskContentList { get; set; } = default!;
                    }

                    public class Previous
                    {
                        /// <summary>
                        /// 获取或设置意图名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("intent")]
                        [System.Text.Json.Serialization.JsonPropertyName("intent")]
                        public string IntentName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置技能名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skill")]
                        [System.Text.Json.Serialization.JsonPropertyName("skill")]
                        public string SkillName { get; set; } = default!;
                    }

                    public class Next : Previous
                    {
                    }

                    public class NormalAnswerConfig
                    {
                        public static class Types
                        {
                            public class Answer
                            {
                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置回答内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public object Content { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否合并。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merge_answer")]
                        [System.Text.Json.Serialization.JsonPropertyName("merge_answer")]
                        public bool RequireMergeAnswer { get; set; }

                        /// <summary>
                        /// 获取或设置回答列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("answer")]
                        [System.Text.Json.Serialization.JsonPropertyName("answer")]
                        public Types.Answer[] AnswerList { get; set; } = default!;
                    }

                    public class ApiAnswerConfig
                    {
                        public static class Types
                        {
                            public class Argument
                            {
                                public static class Types
                                {
                                    public class Item
                                    {
                                        /// <summary>
                                        /// 获取或设置参数名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置是否必填。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("input")]
                                        [System.Text.Json.Serialization.JsonPropertyName("input")]
                                        public bool IsRequired { get; set; }

                                        /// <summary>
                                        /// 获取或设置参数含义。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("desc")]
                                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                        public string Description { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置对应语义槽。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("slot")]
                                        [System.Text.Json.Serialization.JsonPropertyName("slot")]
                                        public string Slot { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置默认值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("default_value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("default_value")]
                                        public string DefaultValue { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置追问话术列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ask_content")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ask_content")]
                                        public string[]? AskContentList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置入参列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("input")]
                                [System.Text.Json.Serialization.JsonPropertyName("input")]
                                public Types.Item[]? InputArgumentList { get; set; }

                                /// <summary>
                                /// 获取或设置出参列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("output")]
                                [System.Text.Json.Serialization.JsonPropertyName("output")]
                                public Types.Item[]? OutArgumentList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置服务接口调用 API。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("api")]
                        [System.Text.Json.Serialization.JsonPropertyName("api")]
                        public string Api { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 API 类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("http_method")]
                        [System.Text.Json.Serialization.JsonPropertyName("http_method")]
                        public string HttpMethod { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 API 地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("http_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("http_url")]
                        public string HttpUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否征求用户意见。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_confirm")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_confirm")]
                        public bool RequireConfirm { get; set; }

                        /// <summary>
                        /// 获取或设置征求语句。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_confirm_response")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_confirm_response")]
                        public string? ConfirmResponse { get; set; }

                        /// <summary>
                        /// 获取或设置参数信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("arguments")]
                        [System.Text.Json.Serialization.JsonPropertyName("arguments")]
                        public Types.Argument Argument { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结果列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public Result[] ResultList { get; set; } = default!;
                    }

                    public class AskSlotAnswerConfig
                    {
                        public static class Types
                        {
                            public class Argument
                            {
                                /// <summary>
                                /// 获取或设置参数名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置对应语义槽。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("slot")]
                                [System.Text.Json.Serialization.JsonPropertyName("slot")]
                                public string Slot { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置追问话术列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ask_content")]
                                [System.Text.Json.Serialization.JsonPropertyName("ask_content")]
                                public string[]? AskContentList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置语义槽信息追问 API。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("api")]
                        [System.Text.Json.Serialization.JsonPropertyName("api")]
                        public string Api { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置参数列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("arguments")]
                        [System.Text.Json.Serialization.JsonPropertyName("arguments")]
                        public Types.Argument[]? ArgumentList { get; set; }

                        /// <summary>
                        /// 获取或设置结果列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public Result[] ResultList { get; set; } = default!;
                    }

                    public class AskAnswerConfig
                    {
                        /// <summary>
                        /// 获取或设置机器人提问 API。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("api")]
                        [System.Text.Json.Serialization.JsonPropertyName("api")]
                        public string Api { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question")]
                        [System.Text.Json.Serialization.JsonPropertyName("question")]
                        public string Question { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结果列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public Result[] ResultList { get; set; } = default!;
                    }

                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string ErrorCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string ErrorDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回答配置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("answer_config_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("answer_config_type")]
                        public int AnswerConfigType { get; set; }

                        /// <summary>
                        /// 获取或设置回答。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("answer")]
                        [System.Text.Json.Serialization.JsonPropertyName("answer")]
                        public string Answer { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置普通技能信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("normal_answer_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("normal_answer_config")]
                        public NormalAnswerConfig? AnswerConfigForNormal { get; set; }

                        /// <summary>
                        /// 获取或设置服务接口调用信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("api_answer_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("api_answer_config")]
                        public ApiAnswerConfig? AnswerConfigForApi { get; set; }

                        /// <summary>
                        /// 获取或设置语义槽追问信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ask_slot_answer_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("ask_slot_answer_config")]
                        public AskSlotAnswerConfig? AnswerConfigForAskSlot { get; set; }

                        /// <summary>
                        /// 获取或设置机器人提问信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ask_answer_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("ask_answer_config")]
                        public AskAnswerConfig? AnswerConfigForAsk { get; set; }

                        /// <summary>
                        /// 获取或设置机器人动态提问信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dynamic_ask_answer_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("dynamic_ask_answer_config")]
                        public AskAnswerConfig? AnswerConfigForAskDynamic { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置语义槽列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slots")]
                [System.Text.Json.Serialization.JsonPropertyName("slots")]
                public Types.Slot[] IntentQuestionList { get; set; } = default!;

                /// <summary>
                /// 获取或设置前置对话列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre")]
                [System.Text.Json.Serialization.JsonPropertyName("pre")]
                public Types.Previous[] PreviousList { get; set; } = default!;

                /// <summary>
                /// 获取或设置后续对话列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next")]
                [System.Text.Json.Serialization.JsonPropertyName("next")]
                public Types.Next[] NextList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否追问。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keep_ask")]
                [System.Text.Json.Serialization.JsonPropertyName("keep_ask")]
                public bool IsKeepAsk { get; set; }

                /// <summary>
                /// 获取或设置最大追问次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keep_ask_num")]
                [System.Text.Json.Serialization.JsonPropertyName("keep_ask_num")]
                public int KeepAskCount { get; set; }

                /// <summary>
                /// 获取或设置回答配置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_config_type")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_config_type")]
                public int AnswerConfigType { get; set; }

                /// <summary>
                /// 获取或设置普通技能信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("normal_answer_config")]
                [System.Text.Json.Serialization.JsonPropertyName("normal_answer_config")]
                public Types.NormalAnswerConfig? AnswerConfigForNormal { get; set; }

                /// <summary>
                /// 获取或设置服务接口调用信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("api_answer_config")]
                [System.Text.Json.Serialization.JsonPropertyName("api_answer_config")]
                public Types.ApiAnswerConfig? AnswerConfigForApi { get; set; }

                /// <summary>
                /// 获取或设置语义槽追问信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ask_slot_answer_config")]
                [System.Text.Json.Serialization.JsonPropertyName("ask_slot_answer_config")]
                public Types.AskSlotAnswerConfig? AnswerConfigForAskSlot { get; set; }

                /// <summary>
                /// 获取或设置机器人提问信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ask_answer_config")]
                [System.Text.Json.Serialization.JsonPropertyName("ask_answer_config")]
                public Types.AskAnswerConfig? AnswerConfigForAsk { get; set; }

                /// <summary>
                /// 获取或设置机器人动态提问信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dynamic_ask_answer_config")]
                [System.Text.Json.Serialization.JsonPropertyName("dynamic_ask_answer_config")]
                public Types.AskAnswerConfig? AnswerConfigForAskDynamic { get; set; }
            }
        }
    }
}
