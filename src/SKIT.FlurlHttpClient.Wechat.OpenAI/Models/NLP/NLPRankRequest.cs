using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /nlp/rank/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class NLPRankRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedUrlEncoded
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Candidate
                    {
                        /// <summary>
                        /// 获取或设置候选词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置输入文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string QueryString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置候选词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("candidates")]
                [System.Text.Json.Serialization.JsonPropertyName("candidates")]
                public IList<Types.Candidate> CandidateList { get; set; } = new List<Types.Candidate>();
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
