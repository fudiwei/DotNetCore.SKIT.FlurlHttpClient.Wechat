namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /risk/getpublickey 接口的请求。</para>
    /// </summary>
    public class GetRiskPublicKeyRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.MD5"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.MD5;
#pragma warning restore CS8765
    }
}
