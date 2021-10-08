using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/openapi/create 接口的请求。</para>
    /// </summary>
    public class OpenApiCreateRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置联系人名字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// 获取或设置联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechat")]
        [System.Text.Json.Serialization.JsonPropertyName("wechat")]
        public string Wechat { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }
    }
}
