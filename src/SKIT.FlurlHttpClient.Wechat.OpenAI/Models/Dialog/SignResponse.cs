using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /sign/{TOKEN} 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-10 下线。")]
    public class SignResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置请求签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature")]
        [System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string Signature { get; set; } = default!;

        /// <summary>
        /// 获取或设置有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiresIn")]
        [System.Text.Json.Serialization.JsonPropertyName("expiresIn")]
        public int ExpiresIn { get; set; }
    }
}
