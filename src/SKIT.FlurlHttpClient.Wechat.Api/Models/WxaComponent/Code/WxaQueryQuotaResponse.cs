using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/queryquota 接口的响应。</para>
    /// </summary>
    public class WxaQueryQuotaResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置提审次数次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rest")]
        [System.Text.Json.Serialization.JsonPropertyName("rest")]
        public int RestCommitCount { get; set; }

        /// <summary>
        /// 获取或设置当月分配提审次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int MaxCommitCount { get; set; }

        /// <summary>
        /// 获取或设置剩余加急次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("speedup_rest")]
        [System.Text.Json.Serialization.JsonPropertyName("speedup_rest")]
        public int RestSpeedupCount { get; set; }

        /// <summary>
        /// 获取或设置当月分配加急次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("speedup_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("speedup_limit")]
        public int MaxSpeedupCount { get; set; }
    }
}
