using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Resources
{
    /// <summary>
    /// <para>表示 PAYSCORE.USER_OPEN_SERVICE 通知的数据。</para>
    /// <para>表示 PAYSCORE.USER_CLOSE_SERVICE 通知的数据。</para>
    /// </summary>
    public class PayScorePermissionsResource : WechatTenpayCallback.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户签约单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置授权协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_code")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_code")]
        public string? AuthorizationCode { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置回调状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_service_status")]
        [System.Text.Json.Serialization.JsonPropertyName("user_service_status")]
        public string? UserServiceStatus { get; set; }

        /// <summary>
        /// 获取或设置服务开启或解除授权时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openorclose_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonWithoutSeparatorsNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("openorclose_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonWithoutSeparatorsNullableDateTimeOffsetConverter))]
        public DateTimeOffset? OpenOrCloseTime { get; set; }
    }
}
