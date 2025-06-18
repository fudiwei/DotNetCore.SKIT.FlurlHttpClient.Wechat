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
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
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
