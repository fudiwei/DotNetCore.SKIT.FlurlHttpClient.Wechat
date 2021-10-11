using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/recommend_questions/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiNLPRecommendQuestionsResponse : WechatOpenAIResponse<OpenApiNLPRecommendQuestionsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置推荐的结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("results")]
                [System.Text.Json.Serialization.JsonPropertyName("results")]
                public string[] ResultList { get; set; } = default!;
            }
        }
    }
}
