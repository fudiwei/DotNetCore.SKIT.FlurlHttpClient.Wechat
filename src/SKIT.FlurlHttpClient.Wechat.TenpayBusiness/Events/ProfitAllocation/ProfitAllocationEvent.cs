namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Events
{
    /// <summary>
    /// <para>表示 profit_allocation.finished 通知的数据。</para>
    /// </summary>
    public class ProfitAllocationEvent : WechatTenpayBusinessEvent<RefundEvent.Types.EventContent>
    {
        public static class Types
        {
            public class EventContent
            {
                public static class Types
                {
                    public class AllocationDetail
                    {
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
                /// 获取或设置分账明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allocations")]
                [System.Text.Json.Serialization.JsonPropertyName("allocations")]
                public Types.AllocationDetail[] AllocationDetailList { get; set; } = default!;
            }
        }
    }
}
