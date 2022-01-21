namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /funds/get 接口的响应。</para>
    /// </summary>
    public class FundsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Fund
                    {
                        public static class Types
                        {
                            public class Credit
                            {
                                /// <summary>
                                /// 获取或设置额度（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limit_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("limit_amount")]
                                public int LimitAmount { get; set; }

                                /// <summary>
                                /// 获取或设置可分配金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("usable_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("usable_amount")]
                                public int UsableAmount { get; set; }

                                /// <summary>
                                /// 获取或设置已用金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("used_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("used_amount")]
                                public int UsedAmount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置资金账户类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fund_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
                        public string FundType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资金余额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("balance")]
                        [System.Text.Json.Serialization.JsonPropertyName("balance")]
                        public int Balance { get; set; }

                        /// <summary>
                        /// 获取或设置固定信用金信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("credit_roll_spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("credit_roll_spec")]
                        public Types.Credit? Credit { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置资金账户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Fund[] FundList { get; set; } = default!;
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
