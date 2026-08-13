namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/card/card-links/unbind-card-link 接口的响应。</para>
    /// </summary>
    public class UnbindBrandCardLinkResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易场景类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_scene")]
        public string PaymentScene { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_link_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("card_link_mchid")]
        public string? CardLinkMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }
    }
}
