using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/news-abstraction/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiNLPNewsAbstractionResponse : WechatOpenAIResponse<OpenApiNLPNewsAbstractionResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置摘要提取的结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("abstraction")]
                [System.Text.Json.Serialization.JsonPropertyName("abstraction")]
                public string Result { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否适合提取摘要的分类标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("classification")]
                [System.Text.Json.Serialization.JsonPropertyName("classification")]
                public bool HasClassification { get; set; }

                /// <summary>
                /// 获取或设置分值（范围：0～1）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prob")]
                [System.Text.Json.Serialization.JsonPropertyName("prob")]
                public double Score { get; set; }
            }
        }
    }
}
