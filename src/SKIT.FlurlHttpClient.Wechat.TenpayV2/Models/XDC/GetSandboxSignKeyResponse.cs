namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /xdc/apiv2getsignkey/sign/getsignkey 接口的响应。</para>
    /// </summary>
    public class GetSandboxSignKeyResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置沙箱密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sandbox_signkey")]
        [System.Text.Json.Serialization.JsonPropertyName("sandbox_signkey")]
        public string SandboxSignKey { get; set; } = default!;
    }
}
