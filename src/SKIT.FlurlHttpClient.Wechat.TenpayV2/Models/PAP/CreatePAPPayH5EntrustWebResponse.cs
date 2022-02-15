namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/h5entrustweb 接口的响应。</para>
    /// </summary>
    public class CreatePAPPayH5EntrustWebResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置签约页面 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_url")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; } = default!;
    }
}
