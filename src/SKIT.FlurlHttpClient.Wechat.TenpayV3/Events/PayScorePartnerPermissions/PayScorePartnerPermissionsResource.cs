using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 PAYSCORE.USER_OPEN_SERVICE 通知的数据。</para>
    /// <para>表示 PAYSCORE.USER_CLOSE_SERVICE 通知的数据。</para>
    /// </summary>
    public class PayScorePartnerPermissionsResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

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
        /// 获取或设置用户在服务商下唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

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
