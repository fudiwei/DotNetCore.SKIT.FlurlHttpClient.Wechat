using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/profitsharing/orders 接口的响应。</para>
    /// </summary>
    public class GetEcommerceProfitSharingOrderByOutOrderNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Receiver
            {
                /// <summary>
                /// 获取或设置分账接收商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账接收方类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账接收方账户。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_account")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_account")]
                public string Account { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置分账描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public string Result { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }

                /// <summary>
                /// 获取或设置分账完成时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finish_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? FinishTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

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
        /// 获取或设置分账单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置分账接收方列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receivers")]
        [System.Text.Json.Serialization.JsonPropertyName("receivers")]
        public Types.Receiver[]? ReceiverList { get; set; }

        /// <summary>
        /// 获取或设置分账完结金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_amount")]
        public int? FinishAmount { get; set; }

        /// <summary>
        /// 获取或设置分账完结描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_description")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_description")]
        public string? FinishDescription { get; set; }
    }
}
