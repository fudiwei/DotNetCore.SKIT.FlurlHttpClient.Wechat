using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/shopping-receipt/customentrances/{brand_id} 接口的请求。</para>
    /// </summary>
    public class ModifyMarketingShoppingReceiptCustomEntranceRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class JumpLink : CreateMarketingShoppingReceiptCustomEntranceRequest.Types.JumpLink
            {
            }
        }

        /// <summary>
        /// 获取或设置自定义入口种类。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_entrance_type")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_entrance_type")]
        public string? CustomEntranceType { get; set; }

        /// <summary>
        /// 获取或设置副标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subtitle")]
        [System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public string? SubTitle { get; set; }

        /// <summary>
        /// 获取或设置商品缩略图 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_thumbnail_url")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_thumbnail_url")]
        public string? GoodsThumbnailUrl { get; set; }

        /// <summary>
        /// 获取或设置入口展示开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置入口展示结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置自定义入口状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_entrance_state")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_entrance_state")]
        public string? CustomEntranceState { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求业务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jump_link")]
        [System.Text.Json.Serialization.JsonPropertyName("jump_link")]
        public Types.JumpLink? JumpLink { get; set; }
    }
}
