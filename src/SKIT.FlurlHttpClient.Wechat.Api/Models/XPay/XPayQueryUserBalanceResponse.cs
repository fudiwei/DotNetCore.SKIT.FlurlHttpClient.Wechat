namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_user_balance 接口的响应。</para>
    /// </summary>
    public class XPayQueryUserBalanceResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置代币总余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置赠送账户的代币余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("present_balance")]
        public int PresentBalance { get; set; }

        /// <summary>
        /// 获取或设置是否满足首充活动。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_save_flag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("first_save_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsFirstSave { get; set; }

        /// <summary>
        /// 获取或设置累计现金充值获得的代币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_save")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_save")]
        public int SumSave { get; set; }

        /// <summary>
        /// 获取或设置累计赠送的代币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_present")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_present")]
        public int SumPresent { get; set; }

        /// <summary>
        /// 获取或设置累计获得的代币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_balance")]
        public int SumBalance { get; set; }

        /// <summary>
        /// 获取或设置累计总消耗代币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_cost")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_cost")]
        public int SumCost { get; set; }
    }
}
