namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/code/decrypt 接口的请求。</para>
    /// </summary>
    public class CardCodeDecryptRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置经过加密的卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encrypt_code")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypt_code")]
        public string EncryptedCardCode { get; set; } = string.Empty;
    }
}
