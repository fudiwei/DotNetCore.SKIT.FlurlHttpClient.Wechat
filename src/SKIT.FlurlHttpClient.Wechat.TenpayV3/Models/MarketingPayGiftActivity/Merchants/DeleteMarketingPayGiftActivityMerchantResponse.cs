using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/paygiftactivity/activities/{activity_id}/merchants/delete 接口的响应。</para>
    /// </summary>
    public class DeleteMarketingPayGiftActivityMerchantResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = default!;

        /// <summary>
        /// 获取或设置添加时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delete_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delete_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset DeleteTime { get; set; }
    }
}
