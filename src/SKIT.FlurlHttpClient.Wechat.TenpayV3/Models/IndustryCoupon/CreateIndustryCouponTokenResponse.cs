using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /industry-coupon/tokens 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateIndustryCouponTokenResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置切卡组件 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置 Token 过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expires_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }
    }
}
