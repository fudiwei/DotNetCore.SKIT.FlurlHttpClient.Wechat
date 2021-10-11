using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/rank/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiNLPRankResponse : WechatOpenAIResponse<OpenApiNLPRankResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置候选词信息项。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question")]
                        [System.Text.Json.Serialization.JsonPropertyName("question")]
                        public string Sentiment { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分值（范围：0～1）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("score")]
                        [System.Text.Json.Serialization.JsonPropertyName("score")]
                        public double Score { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("results")]
                [System.Text.Json.Serialization.JsonPropertyName("results")]
                public Types.Result[] ResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否有 Exact Match 候选。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exact_match")]
                [System.Text.Json.Serialization.JsonPropertyName("exact_match")]
                public bool HasExactMatch { get; set; }
            }
        }
    }
}
