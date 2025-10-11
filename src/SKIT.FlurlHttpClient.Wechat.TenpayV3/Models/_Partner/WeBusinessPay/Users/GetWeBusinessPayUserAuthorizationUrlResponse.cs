using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/users/{user_id}/authorization-url 接口的响应。</para>
    /// </summary>
    public class GetWeBusinessPayUserAuthorizationUrlResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户企业员工 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业应用类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_type")]
        [System.Text.Json.Serialization.JsonPropertyName("application_type")]
        public string ApplicationType { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_url")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_url")]
        public string? AuthorizationUrl { get; set; }

        /// <summary>
        /// 获取或设置小程序查询参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_query")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_query")]
        public string? MiniProgramQueryString { get; set; }

        /// <summary>
        /// 获取或设置小程序业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_business_type")]
        public string? MiniProgramBusinessType { get; set; }

        /// <summary>
        /// 获取或设置链接失效时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }
    }
}
