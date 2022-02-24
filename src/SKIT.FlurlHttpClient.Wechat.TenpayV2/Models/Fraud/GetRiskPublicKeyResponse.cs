namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /risk/getpublickey 接口的响应。</para>
    /// </summary>
    public class GetRiskPublicKeyResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（请忽略此字段）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置 RSA 公钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pub_key")]
        [System.Text.Json.Serialization.JsonPropertyName("pub_key")]
        public string PublicKey { get; set; } = default!;
    }
}
