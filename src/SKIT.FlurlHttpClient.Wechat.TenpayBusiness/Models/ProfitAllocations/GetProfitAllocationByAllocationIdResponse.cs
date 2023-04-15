using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/{allocation_id} 接口的响应。</para>
    /// </summary>
    public class GetProfitAllocationByAllocationIdResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class AllocationDetail
            {
                public static class Types
                {
                    public class Failure : GetProfitAllocationReceiverAccountApplicationByApplicationIdResponse.Types.Failure
                    {
                    }
                }

                /// <summary>
                /// 获取或设置平台分账明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_allocation_detail_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_allocation_detail_id")]
                public string OutAllocationDetailId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微企付分账明细单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allocation_detail_id")]
                [System.Text.Json.Serialization.JsonPropertyName("allocation_detail_id")]
                public string AllocationDetailId { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收方账户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_acct_id")]
                public string ReceiverAccountId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置分账结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public string Result { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账成功时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("succeeded_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("succeeded_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? SucceedTime { get; set; }

                /// <summary>
                /// 获取或设置分账原因描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置失败信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
                public Types.Failure? Failure { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置平台分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_allocation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_allocation_id")]
        public string OutAllocationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allocation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("allocation_id")]
        public string AllocationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置分账状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置分账完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finished_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("finished_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? FinishTime { get; set; }

        /// <summary>
        /// 获取或设置分账完成金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_amount")]
        public int? FinishAmount { get; set; }

        /// <summary>
        /// 获取或设置分账完成描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finish_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("finish_desc")]
        public string? FinishDescription { get; set; }

        /// <summary>
        /// 获取或设置分账明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allocations")]
        [System.Text.Json.Serialization.JsonPropertyName("allocations")]
        public Types.AllocationDetail[] AllocationDetailList { get; set; } = default!;
    }
}
