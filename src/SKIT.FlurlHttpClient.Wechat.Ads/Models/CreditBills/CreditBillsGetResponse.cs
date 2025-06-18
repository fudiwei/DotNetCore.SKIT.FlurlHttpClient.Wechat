namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /credit_bills/get 接口的响应。</para>
    /// </summary>
    public class CreditBillsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CreditBill
                    {
                        /// <summary>
                        /// 获取或设置出账单日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bill_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
                        public string BillDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置账单开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置账单截止时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置最后还款时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("due_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("due_time")]
                        public long DueTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置待还金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_repay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_repay_amount")]
                        public int RepayingAmount { get; set; }

                        /// <summary>
                        /// 获取或设置已还金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("repaid_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("repaid_amount")]
                        public int RepaidAmount { get; set; }
                    }

                    public class Pagination : Abstractions.CommonPagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置资金账户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.CreditBill[] CreditBillList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
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
