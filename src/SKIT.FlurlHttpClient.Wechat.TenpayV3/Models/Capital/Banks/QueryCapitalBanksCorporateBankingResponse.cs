namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /capital/capitallhh/banks/corporate-banking 接口的响应。</para>
    /// </summary>
    public class QueryCapitalBanksCorporateBankingResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Bank : QueryCapitalBanksPersonalBankingResponse.Types.Bank
            {
            }
        }

        /// <summary>
        /// 获取或设置银行列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Bank[] BankList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置数据总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
