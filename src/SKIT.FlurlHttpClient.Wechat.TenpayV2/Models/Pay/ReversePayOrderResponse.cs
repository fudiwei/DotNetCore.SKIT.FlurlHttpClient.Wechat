namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/pay/reverse 接口的响应。</para>
    /// </summary>
    public class ReversePayOrderResponse : WechatTenpaySignableResponse
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
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置是否需要重调。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recall")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("recall")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoBooleanConverter))]
        public bool RequireRecall { get; set; }
    }
}
