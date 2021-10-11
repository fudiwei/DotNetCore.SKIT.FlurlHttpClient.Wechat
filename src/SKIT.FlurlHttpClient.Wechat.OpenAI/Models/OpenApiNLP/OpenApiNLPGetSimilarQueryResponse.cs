using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/get_similar_query/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiNLPGetSimilarQueryResponse : WechatOpenAIResponse<OpenApiNLPGetSimilarQueryResponse.Types.Data>
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
                        /// 获取或设置相似问题信息项。
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

                        /// <summary>
                        /// 获取或设置来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public string Source { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Result[] ResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置耗时（单位：毫秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("costime")]
                [System.Text.Json.Serialization.JsonPropertyName("costime")]
                public int CostTime { get; set; }
            }
        }
    }
}
