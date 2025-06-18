namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_biz_balance 接口的响应。</para>
    /// </summary>
    public class XPayQueryBusinessBalanceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Balance
            {
                /// <summary>
                /// 获取或设置余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal Amount { get; set; }

                /// <summary>
                /// 获取或设置币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency_code")]
                [System.Text.Json.Serialization.JsonPropertyName("currency_code")]
                public string Currency { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置可提现余额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance_available")]
        [System.Text.Json.Serialization.JsonPropertyName("balance_available")]
        public Types.Balance AvailableBalance { get; set; } = default!;
    }
}
