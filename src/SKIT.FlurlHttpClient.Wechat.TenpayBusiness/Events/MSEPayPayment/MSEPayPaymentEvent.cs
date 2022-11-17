﻿using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Events
{
    /// <summary>
    /// <para>表示 pay.created 通知的数据。</para>
    /// <para>表示 pay.bank_accept 通知的数据。</para>
    /// <para>表示 pay.succeeded 通知的数据。</para>
    /// <para>表示 pay.failed 通知的数据。</para>
    /// <para>表示 pay.revoked 通知的数据。</para>
    /// </summary>
    public class MSEPayPaymentEvent : WechatTenpayBusinessEvent<MSEPayPaymentEvent.Types.EventContent>
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置平台支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_payment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_payment_id")]
                public string OutPaymentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微企付支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
                public string PaymentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置付款方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("purchaser_id")]
                [System.Text.Json.Serialization.JsonPropertyName("purchaser_id")]
                public string PurchaserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置收款方企业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bargainor_ent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bargainor_ent_id")]
                public string BargainorEnterpriseId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
                public string? FailedReason { get; set; }

                /// <summary>
                /// 获取或设置支付成功时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_succ_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("pay_succ_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? PaySuccessTime { get; set; }
            }
        }
    }
}
