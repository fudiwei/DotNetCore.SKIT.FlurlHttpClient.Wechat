namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getbankbynum 接口的请求。</para>
    /// </summary>
    public class ShopFundsGetBankByNumberRequest : WechatApiRequest, IInferable<ShopFundsGetBankByNumberRequest, ShopFundsGetBankByNumberResponse>
    {
        /// <summary>
        /// 获取或设置银行账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_number")]
        [System.Text.Json.Serialization.JsonPropertyName("account_number")]
        public string BankAccountNumber { get; set; } = string.Empty;
    }
}
