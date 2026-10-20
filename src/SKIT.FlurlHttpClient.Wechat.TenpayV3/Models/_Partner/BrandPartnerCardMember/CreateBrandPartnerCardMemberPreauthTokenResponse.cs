using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/partner/card-member/pre-auth-tokens 接口的响应。</para>
    /// </summary>
    public class CreateBrandPartnerCardMemberPreauthTokenResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预授权 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置预授权 Token 过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }
    }
}
