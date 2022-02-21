namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund_statements_detailed/get 接口的响应。</para>
    /// </summary>
    public class FundStatementsDetailedGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FundStatement
                    {
                        /// <summary>
                        /// 获取或设置资金账户类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fund_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
                        public string FundType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置余额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置交易单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bill_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("bill_number")]
                        public string BillNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置交易描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置交易发生时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置资金账户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.FundStatement[] FundStatementList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public CommonPagination Pagination { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
