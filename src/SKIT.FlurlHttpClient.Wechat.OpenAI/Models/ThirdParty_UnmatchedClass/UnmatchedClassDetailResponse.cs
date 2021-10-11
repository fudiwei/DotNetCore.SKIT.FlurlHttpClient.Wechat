using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/unmatched/class/detail 接口的响应。</para>
    /// </summary>
    public class UnmatchedClassDetailResponse : WechatOpenAIThirdPartyResponse<UnmatchedClassDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Class
                    {
                        /// <summary>
                        /// 获取或设置询问话术。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query")]
                        [System.Text.Json.Serialization.JsonPropertyName("query")]
                        public string Query { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回答话术。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("answer")]
                        [System.Text.Json.Serialization.JsonPropertyName("answer")]
                        public string Answer { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置未命中数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置话术列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Class[] ClassList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置分页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_no")]
                [System.Text.Json.Serialization.JsonPropertyName("page_no")]
                public int Page { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_size")]
                [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                public int Limit { get; set; }
            }
        }
    }
}
