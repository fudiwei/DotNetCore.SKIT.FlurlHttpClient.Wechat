using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [GET] /v1/async/fetch 接口的响应。</para>
    /// </summary>
    public class AsyncFetchResponse : WechatOpenAIThirdPartyResponse<AsyncFetchResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置任务进度字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("progress")]
                [System.Text.Json.Serialization.JsonPropertyName("progress")]
                public string ProgressString { get; set; } = default!;

                /// <summary>
                /// 获取或设置任务耗时字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cost")]
                [System.Text.Json.Serialization.JsonPropertyName("cost")]
                public string CostString { get; set; } = default!;

                /// <summary>
                /// 获取或设置导出任务的下载链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置接口访问令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_skill_info")]
                [System.Text.Json.Serialization.JsonPropertyName("success_skill_info")]
                public IDictionary<string, object>? SuccessSkillMap { get; set; }
            }
        }
    }
}
