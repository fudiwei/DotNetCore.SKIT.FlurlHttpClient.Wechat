using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/translate_cn2en/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiNLPTranslateChinese2EnglishResponse : WechatOpenAIResponse<OpenApiNLPTranslateChinese2EnglishResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public string Result { get; set; } = default!;
            }
        }
    }
}
