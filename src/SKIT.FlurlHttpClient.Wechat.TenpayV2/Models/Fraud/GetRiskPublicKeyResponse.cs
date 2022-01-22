namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /risk/getpublickey 接口的响应。</para>
    /// </summary>
    public class GetRiskPublicKeyResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 RSA 公钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pub_key")]
        [System.Text.Json.Serialization.JsonPropertyName("pub_key")]
        public string PublicKey { get; set; } = default!;
    }
}
