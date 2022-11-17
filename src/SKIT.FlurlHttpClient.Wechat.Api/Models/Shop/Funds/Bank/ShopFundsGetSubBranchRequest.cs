namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getsubbranch 接口的请求。</para>
    /// </summary>
    public class ShopFundsGetSubBranchRequest : WechatApiRequest, IInferable<ShopFundsGetSubBranchRequest, ShopFundsGetSubBranchResponse>
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
        /// 获取或设置城市编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        [System.Text.Json.Serialization.JsonPropertyName("city_code")]
        public int CityCode { get; set; }

        /// <summary>
        /// 获取或设置银行编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_code")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_code")]
        public string BankCode { get; set; } = string.Empty;
    }
}
