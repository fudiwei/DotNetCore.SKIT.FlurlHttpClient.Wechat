namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/async/fetch 接口的响应。</para>
    /// </summary>
    public class AsyncFetchV2Response : WechatOpenAIResponse<AsyncFetchV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : WechatOpenAIResponseData
            {
                public static class Types
                {
                    public class Intent
                    {
                        /// <summary>
                        /// 获取或设置意图 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long IntentId { get; set; }

                        /// <summary>
                        /// 获取或设置意图名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }

                    public class FailedSkill
                    {
                        /// <summary>
                        /// 获取或设置技能名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }

                    public class SucceededSkill : FailedSkill
                    {
                        /// <summary>
                        /// 获取或设置技能 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long SkillId { get; set; }

                        /// <summary>
                        /// 获取或设置意图列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("intents")]
                        [System.Text.Json.Serialization.JsonPropertyName("intents")]
                        public Types.Intent[] IntentList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置任务进度（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("progress")]
                [System.Text.Json.Serialization.JsonPropertyName("progress")]
                public int Progress { get; set; }

                /// <summary>
                /// 获取或设置任务开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start")]
                [System.Text.Json.Serialization.JsonPropertyName("start")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置任务结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end")]
                [System.Text.Json.Serialization.JsonPropertyName("end")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置导出任务的 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置导入的总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置导入失败的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_count")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_count")]
                public int FailedCount { get; set; }

                /// <summary>
                /// 获取或设置导入失败的技能列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_skill_info")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_skill_info")]
                public Types.FailedSkill[]? FailedSkillList { get; set; }

                /// <summary>
                /// 获取或设置导入成功的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_count")]
                [System.Text.Json.Serialization.JsonPropertyName("success_count")]
                public int SucceededCount { get; set; }

                /// <summary>
                /// 获取或设置导入成功的技能列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_skill_info")]
                [System.Text.Json.Serialization.JsonPropertyName("success_skill_info")]
                public Types.SucceededSkill[]? SucceededSkillList { get; set; }
            }
        }
    }
}
