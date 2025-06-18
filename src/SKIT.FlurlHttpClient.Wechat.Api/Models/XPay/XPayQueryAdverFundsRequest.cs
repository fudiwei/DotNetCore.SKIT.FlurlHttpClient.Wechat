namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_adver_funds 接口的请求。</para>
    /// </summary>
    public class XPayQueryAdverFundsRequest : XPayRequestBase, IInferable<XPayQueryAdverFundsRequest, XPayQueryAdverFundsResponse>
    {
        public static class Types
        {
            public class Filter
            {
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
                /// 获取或设置广告金类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fund_type")]
                [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
                public int? FundsType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置查询过滤条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter")]
        [System.Text.Json.Serialization.JsonPropertyName("filter")]
        public Types.Filter? Filter { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/query_adver_funds";
        }
    }
}
