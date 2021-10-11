using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/document_classify/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class OpenApiNLPDocumentClassifyRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedUrlEncodedFormData
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文章标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置文章正文内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = new Types.Data();
}
}
