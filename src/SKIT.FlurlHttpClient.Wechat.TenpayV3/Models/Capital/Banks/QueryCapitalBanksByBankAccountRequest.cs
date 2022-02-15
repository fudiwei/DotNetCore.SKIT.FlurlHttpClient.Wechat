namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /capital/capitallhh/banks/search-banks-by-bank-account 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class QueryCapitalBanksByBankAccountRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置银行卡号（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
        public string AccountNumber { get; set; } = string.Empty;
    }
}
