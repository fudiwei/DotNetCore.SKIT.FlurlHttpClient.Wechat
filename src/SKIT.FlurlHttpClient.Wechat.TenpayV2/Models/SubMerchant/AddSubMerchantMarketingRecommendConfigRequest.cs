namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/mkt/addrecommendconf 接口的请求。</para>
    /// </summary>
    public class AddSubMerchantMarketingRecommendConfigRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string SubAppId { get; set; } = string.Empty;

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.HMAC_SHA256;
#pragma warning restore CS8765

        /// <summary>
        /// 获取或设置推荐关注的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscribe_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("subscribe_appid")]
        public string? SubscribeAppId { get; set; }

        /// <summary>
        /// 获取或设置支付凭证的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("receipt_appid")]
        public string? ReceiptAppId { get; set; }
    }
}
