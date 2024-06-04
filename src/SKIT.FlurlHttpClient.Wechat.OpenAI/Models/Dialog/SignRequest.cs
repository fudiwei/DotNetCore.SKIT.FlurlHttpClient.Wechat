using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /sign/{TOKEN} 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-10 下线。")]
    public class SignRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Nickname { get; set; }

        /// <summary>
        /// 获取或设置用户头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? AvatarUrl { get; set; }
    }
}
