namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /settle/settlements 接口的响应。</para>
    /// </summary>
    public class QueryHKSettlementsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Settlement
            {
                public static class Types
                {
                    public class Amount
                    {
                        /// <summary>
                        /// 获取或设置已划账金额（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settled")]
                        [System.Text.Json.Serialization.JsonPropertyName("settled")]
                        public int SettledAmount { get; set; }

                        /// <summary>
                        /// 获取或设置未划账金额（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unsettle")]
                        [System.Text.Json.Serialization.JsonPropertyName("unsettle")]
                        public int UnsettledAmount { get; set; }

                        /// <summary>
                        /// 获取或设置结算币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置该结算周期内会发生结算的交易总金额（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay")]
                        public int PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置该结算周期内退款总金额（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund")]
                        public int RefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置该结算周期交易与退款总金额之差（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("net")]
                        [System.Text.Json.Serialization.JsonPropertyName("net")]
                        public int NetAmount { get; set; }

                        /// <summary>
                        /// 获取或设置手续费金额（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("fee")]
                        public int Fee { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置付汇批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("batch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("batch_id")]
                public string BatchId { get; set; } = default!;

                /// <summary>
                /// 获取或设置结算日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_date")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_date")]
                public string SettlementDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置交易开始日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_start_date")]
                public string StartDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置交易结束日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_end_date")]
                public string EndDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public Types.Amount Amount { get; set; } = default!;

                /// <summary>
                /// 获取或设置钱包主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wallet_region")]
                [System.Text.Json.Serialization.JsonPropertyName("wallet_region")]
                public string? WalletRegionType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结算记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Settlement[]? SettlementList { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置结算记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
