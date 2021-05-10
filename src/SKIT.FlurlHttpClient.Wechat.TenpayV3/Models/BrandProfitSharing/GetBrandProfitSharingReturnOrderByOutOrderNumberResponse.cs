using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/profitsharing/returnorders 接口的响应。</para>
    /// </summary>
    public class GetBrandProfitSharingReturnOrderByOutOrderNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_return_no")]
        public string OutReturnNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("return_no")]
        public string ReturnId { get; set; } = default!;

        /// <summary>
        /// 获取或设置回退商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("return_mchid")]
        public string ReturnMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置回退金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置回退结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置回退失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置回退完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? FinishTime { get; set; }
    }
}
