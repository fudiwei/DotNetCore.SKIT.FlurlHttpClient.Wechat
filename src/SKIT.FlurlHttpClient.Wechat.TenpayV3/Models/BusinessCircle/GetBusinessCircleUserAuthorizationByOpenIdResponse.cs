using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /businesscircle/user-authorizations/{openid} 接口的响应。</para>
    /// </summary>
    public class GetBusinessCircleUserAuthorizationByOpenIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_state")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_state")]
        public string AuthorizeState { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? AuthorizeTime { get; set; }

        /// <summary>
        /// 获取或设置取消授权时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deauthorize_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("deauthorize_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? DeauthorizeTime { get; set; }
    }
}
