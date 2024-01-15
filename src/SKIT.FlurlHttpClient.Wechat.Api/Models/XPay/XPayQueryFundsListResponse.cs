namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_funds_bill 接口的响应。</para>
    /// </summary>
    public class XPayQueryFundsListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Bill
            {
                /// <summary>
                /// 获取或设置充值单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_id")]
                public string BillId { get; set; } = default!;

                /// <summary>
                /// 获取或设置充值时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oper_time")]
                [System.Text.Json.Serialization.JsonPropertyName("oper_time")]
                public long OperateTimestamp { get; set; }

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
                /// 获取或设置充值账户 UID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_account_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_account_uid")]
                public int TransferAccountUID { get; set; }

                /// <summary>
                /// 获取或设置充值账户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_account_name")]
                public string TransferAccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置充值金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_amount")]
                public int RransferAmount { get; set; }

                /// <summary>
                /// 获取或设置充值状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告金充值记录列表。
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
