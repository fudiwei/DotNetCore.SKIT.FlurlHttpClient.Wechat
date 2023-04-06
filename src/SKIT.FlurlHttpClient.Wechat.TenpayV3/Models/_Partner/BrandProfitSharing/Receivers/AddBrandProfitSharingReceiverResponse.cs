namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/profitsharing/receivers/add 接口的响应。</para>
    /// </summary>
    public class AddBrandProfitSharingReceiverResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置品牌主商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_mchid")]
        public string BrandMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收方类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string Account { get; set; } = default!;
    }
}
