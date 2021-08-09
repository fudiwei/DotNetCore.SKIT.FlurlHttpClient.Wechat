using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/paygiftactivity/activities/{activity_id}/merchants/add 接口的响应。</para>
    /// </summary>
    public class AddMarketingPayGiftActivityMerchantResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class InvalidMerchant
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置无效原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invalid_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("invalid_reason")]
                public string MerchantMemberAppId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = default!;

        /// <summary>
        /// 获取或设置校验失败的发券商户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_merchant_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_merchant_id_list")]
        public Types.InvalidMerchant[]? InvalidMerchantList { get; set; }

        /// <summary>
        /// 获取或设置添加时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("add_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? AddTime { get; set; }
    }
}
