namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getbanklist 接口的请求。</para>
    /// </summary>
    public class ShopFundsGetBankListRequest : WechatApiRequest, IInferable<ShopFundsGetBankListRequest, ShopFundsGetBankListResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key_words")]
        [System.Text.Json.Serialization.JsonPropertyName("key_words")]
        public string? Keywords { get; set; }

        /// <summary>
        /// 获取或设置银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public int? BankType { get; set; }
    }
}
