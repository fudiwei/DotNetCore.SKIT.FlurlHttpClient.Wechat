using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/settle/prepay-settle-orders/{settle_batch_no} 接口的响应。</para>
    /// </summary>
    public class GetPlatformSolutionEcommerceSettlePrepaySettleOrderBySettleBatchNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class AbnormalSettleResult
            {
                /// <summary>
                /// 获取或设置异常处理方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("abnormal_settle_type")]
                [System.Text.Json.Serialization.JsonPropertyName("abnormal_settle_type")]
                public string AbnormalSettleType { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户异常结算批次单处理单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_abnormal_settle_batch_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_abnormal_settle_batch_no")]
                public string OutAbnormalSettleBatchNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付异常资金付款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("abnormal_fund_receipt_id")]
                [System.Text.Json.Serialization.JsonPropertyName("abnormal_fund_receipt_id")]
                public string AbnormalFundReceiptId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请成功时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_success_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("apply_success_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ApplySuccessTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置个人收款方受理授权 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual_auth_id")]
        [System.Text.Json.Serialization.JsonPropertyName("individual_auth_id")]
        public string? IndividualAuthId { get; set; }

        /// <summary>
        /// 获取或设置商户结算批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_settle_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_settle_batch_no")]
        public string OutSettleBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付结算批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_batch_no")]
        public string SettleBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款方描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scenario")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scenario")]
        public string? TradeScenario { get; set; }

        /// <summary>
        /// 获取或设置批次创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置批次完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? FinishTime { get; set; }

        /// <summary>
        /// 获取或设置异常原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abnormal_type")]
        [System.Text.Json.Serialization.JsonPropertyName("abnormal_type")]
        public string? AbnormalType { get; set; }

        /// <summary>
        /// 获取或设置异常结算处理结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abnormal_settle_result")]
        [System.Text.Json.Serialization.JsonPropertyName("abnormal_settle_result")]
        public Types.AbnormalSettleResult? AbnormalSettleResult { get; set; }
    }
}
