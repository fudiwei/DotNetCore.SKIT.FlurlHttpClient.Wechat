namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /gethotquerylist/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class GetHotQueryListResponse : WechatOpenAIPlatformResponse<GetHotQueryListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class HotQuery
                    {
                        public static class Types
                        {
                            public class Example
                            {
                                /// <summary>
                                /// 获取或设置相似问题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ques")]
                                [System.Text.Json.Serialization.JsonPropertyName("ques")]
                                public string Question { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分数
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("score")]
                                [System.Text.Json.Serialization.JsonPropertyName("score")]
                                public int Score { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置提问总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("askCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("askCount")]
                        public int AskCount { get; set; }

                        /// <summary>
                        /// 获取或设置提问用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("askUserCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("askUserCount")]
                        public int AskUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置问法总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("askUserCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("askUserCount")]
                        public int QuestionCount { get; set; }

                        /// <summary>
                        /// 获取或设置问题类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cluesType")]
                        [System.Text.Json.Serialization.JsonPropertyName("cluesType")]
                        public int ClueType { get; set; }

                        /// <summary>
                        /// 获取或设置示例列表
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exampleQues")]
                        [System.Text.Json.Serialization.JsonPropertyName("exampleQues")]
                        public Types.Example[] ExampleList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置问题类别数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hotQuesClusterCount")]
                [System.Text.Json.Serialization.JsonPropertyName("hotQuesClusterCount")]
                public int HotQuestionClusterCount { get; set; }

                /// <summary>
                /// 获取或设置问题数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hotQuesCount")]
                [System.Text.Json.Serialization.JsonPropertyName("hotQuesCount")]
                public int HotQuestionCount { get; set; }

                /// <summary>
                /// 获取或设置分页总页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("totalPages")]
                [System.Text.Json.Serialization.JsonPropertyName("totalPages")]
                public int TotalPageCount { get; set; }

                /// <summary>
                /// 获取或设置热问列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.HotQuery[] HotQueryList { get; set; } = default!;
            }
        }
    }
}
