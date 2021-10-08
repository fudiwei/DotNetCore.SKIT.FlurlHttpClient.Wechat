using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/user_query_yesterday_data 接口的响应。</para>
    /// </summary>
    public class UserQueryYesterdayDataResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置对话数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("q_a_count")]
        [System.Text.Json.Serialization.JsonPropertyName("q_a_count")]
        public int DialogCount { get; set; }

        /// <summary>
        /// 获取或设置用户数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_count")]
        [System.Text.Json.Serialization.JsonPropertyName("user_count")]
        public int UserCount { get; set; }

        /// <summary>
        /// 获取或设置新消息总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_news_count")]
        [System.Text.Json.Serialization.JsonPropertyName("new_news_count")]
        public int NewMessageCount { get; set; }

        /// <summary>
        /// 获取或设置新消息人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_news_user_count")]
        [System.Text.Json.Serialization.JsonPropertyName("new_news_user_count")]
        public int NewMessageUserCount { get; set; }

        /// <summary>
        /// 获取或设置热问列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hot_query_list")]
        [System.Text.Json.Serialization.JsonPropertyName("hot_query_list")]
        public string[] HotQueryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置命中率（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hit_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("hit_rate")]
        public double HitRate { get; set; }

        /// <summary>
        /// 获取或设置错误率（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miss_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("miss_rate")]
        public double MissRate { get; set; }

        /// <summary>
        /// 获取或设置用户增长率（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_growth_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("user_growth_rate")]
        public double UserGrowthRate { get; set; }

        /// <summary>
        /// 获取或设置命中增长率（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hit_growth_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("hit_growth_rate")]
        public double HitGrowthRate { get; set; }
    }
}
