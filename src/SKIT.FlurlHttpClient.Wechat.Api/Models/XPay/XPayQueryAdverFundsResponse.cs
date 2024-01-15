namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_adver_funds 接口的响应。</para>
    /// </summary>
    public class XPayQueryAdverFundsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AdverFund
            {
                /// <summary>
                /// 获取或设置广告金发放 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fund_id")]
                public string FundId { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告金发放类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fund_type")]
                [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
                public int FundType { get; set; }

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
                /// 获取或设置发放广告金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置剩余可用金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remain_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("remain_amount")]
                public int RemainAmount { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long? ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告金发放记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adver_funds_list")]
        [System.Text.Json.Serialization.JsonPropertyName("adver_funds_list")]
        public Types.AdverFund[] AdverFundList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_page")]
        [System.Text.Json.Serialization.JsonPropertyName("total_page")]
        public int TotalPage { get; set; }
    }
}
