using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/merchant/{sub_mchid}/check-status 接口的响应。</para>
    /// </summary>
    public class CheckNewTaxControlFapiaoMerchantStatusResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class ThirdPartyMode
            {
                /// <summary>
                /// 获取或设置接入状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;
            }

            public class DigitalTaxMode
            {
                public static class Types
                {
                    public class BillingPerson
                    {
                        /// <summary>
                        /// 获取或设置开票人 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开票人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }

                    public class Ability
                    {
                        /// <summary>
                        /// 获取或设置能力类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置授权状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string AuthorizeStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置授权失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorize_fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorize_fail_reason")]
                        public string? AuthorizeFailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置接入状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置开票人信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_person_info")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_person_info")]
                public Types.BillingPerson[]? BillingPersonList { get; set; }

                /// <summary>
                /// 获取或设置接入时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("access_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? AccessTime { get; set; }

                /// <summary>
                /// 获取或设置过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expired_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expired_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? ExpireTime { get; set; }

                /// <summary>
                /// 获取或设置接入失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("access_fail_reason")]
                public string? AccessFailReason { get; set; }

                /// <summary>
                /// 获取或设置能力信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ability_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ability_info")]
                public Types.Ability[]? AbilityList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置第三方开票模式相关信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("third_mode")]
        public Types.ThirdPartyMode? ThirdPartyMode { get; set; }

        /// <summary>
        /// 获取或设置数电发票模式相关信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("digital_tax_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("digital_tax_mode")]
        public Types.DigitalTaxMode? DigitalTaxMode { get; set; }
    }
}
