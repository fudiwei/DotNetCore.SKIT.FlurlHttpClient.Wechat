namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_funds_bill 接口的请求。</para>
    /// </summary>
    public class XPayQueryFundsListRequest : XPayRequestBase, IInferable<XPayQueryFundsListRequest, XPayQueryFundsListResponse>
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置充值开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oper_time_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("oper_time_begin")]
                public long? OperateBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置充值结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("oper_time_end")]
                [System.Text.Json.Serialization.JsonPropertyName("oper_time_end")]
                public long? OperateEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置广告金充值单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_id")]
                public string? BillId { get; set; }
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
            return "/xpay/query_funds_bill";
        }
    }
}
