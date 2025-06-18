namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_recover_bill 接口的响应。</para>
    /// </summary>
    public class XPayQueryRecoverListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Bill
            {
                /// <summary>
                /// 获取或设置回收单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_id")]
                public string BillId { get; set; } = default!;

                /// <summary>
                /// 获取或设置回收时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recover_time")]
                [System.Text.Json.Serialization.JsonPropertyName("recover_time")]
                public long RecoverTimestamp { get; set; }

                /// <summary>
                /// 获取或设置对应广告金 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fund_id")]
                public string FundId { get; set; } = default!;

                /// <summary>
                /// 获取或设置结算周期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_begin")]
                public long SettleBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结算周期结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_end")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_end")]
                public long SettleEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置回收账户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recover_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("recover_account_name")]
                public string TransferAccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置回收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recover_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("recover_amount")]
                public int RecoverAmount { get; set; }

                /// <summary>
                /// 获取或设置对应的退款订单 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_order_list")]
                public string[]? RefundOrderIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告金回收记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_list")]
        public Types.Bill[] BillList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_page")]
        [System.Text.Json.Serialization.JsonPropertyName("total_page")]
        public int TotalPage { get; set; }
    }
}
