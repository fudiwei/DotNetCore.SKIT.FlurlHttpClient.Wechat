using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /gethotquerydetail/{TOKEN} 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-07 下线。")]
    public class GetHotQueryDetailResponse : WechatOpenAIResponse<GetHotQueryDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class HotQuery
                    {
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
                        /// 获取或设置命中的技能。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hitIntent")]
                        [System.Text.Json.Serialization.JsonPropertyName("hitIntent")]
                        public string? HitIntent { get; set; }

                        /// <summary>
                        /// 获取或设置相似问题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ques")]
                        [System.Text.Json.Serialization.JsonPropertyName("ques")]
                        public string Question { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题得分。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("score")]
                        [System.Text.Json.Serialization.JsonPropertyName("score")]
                        public decimal Score { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置问题数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
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

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override int? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? ReturnMessage { get; set; }
    }
}
