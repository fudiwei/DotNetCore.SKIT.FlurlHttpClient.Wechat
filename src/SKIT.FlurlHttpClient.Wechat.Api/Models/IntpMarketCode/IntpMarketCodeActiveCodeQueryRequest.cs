using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/codeactivequery 接口的请求。</para>
    /// </summary>
    public class IntpMarketCodeActiveCodeQueryRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// 获取或设置该码在批次中的偏移量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_index")]
        [System.Text.Json.Serialization.JsonPropertyName("code_index")]
        public long? CodeIndex { get; set; }

        /// <summary>
        /// 获取或设置原始码。与字段 <see cref="CodeUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置普通码。与字段 <see cref="Code"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_url")]
        [System.Text.Json.Serialization.JsonPropertyName("code_url")]
        public string? CodeUrl { get; set; }
    }
}
