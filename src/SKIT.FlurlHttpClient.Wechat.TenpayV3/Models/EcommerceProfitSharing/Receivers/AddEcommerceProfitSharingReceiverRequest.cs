namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/profitsharing/receivers/add 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class AddEcommerceProfitSharingReceiverRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置电商平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收方类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string Account { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收方商户全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置接收方个人姓名（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encrypted_name")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_name")]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
        public string? EncryptedName { get; set; }

        /// <summary>
        /// 获取或设置与分账方的关系类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("relation_type")]
        public string RelationType { get; set; } = string.Empty;
    }
}
