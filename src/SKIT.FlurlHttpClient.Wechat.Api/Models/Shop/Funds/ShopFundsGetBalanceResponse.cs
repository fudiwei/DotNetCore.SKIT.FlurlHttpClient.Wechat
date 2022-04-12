namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getbalance 接口的响应。</para>
    /// </summary>
    public class ShopFundsGetBalanceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Balance
            {
                /// <summary>
                /// 获取或设置可用余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("available_amount")]
                public int AvailableAmount { get; set; }

                /// <summary>
                /// 获取或设置待结算余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pending_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pending_amount")]
                public int PendingAmount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置余额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance_info")]
        [System.Text.Json.Serialization.JsonPropertyName("balance_info")]
        public Types.Balance Balance { get; set; } = default!;
    }
}
