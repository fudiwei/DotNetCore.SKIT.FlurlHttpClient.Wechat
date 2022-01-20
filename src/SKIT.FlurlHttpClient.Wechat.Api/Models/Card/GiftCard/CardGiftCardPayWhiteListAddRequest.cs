namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/pay/whitelist/add 接口的请求。</para>
    /// </summary>
    public class CardGiftCardPayWhiteListAddRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置微信支付子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
