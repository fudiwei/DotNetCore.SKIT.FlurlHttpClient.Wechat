namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/pay/submch/bind 接口的请求。</para>
    /// </summary>
    public class CardGiftCardPaySubMerchantBindRequest : WechatApiRequest, IInferable<CardGiftCardPaySubMerchantBindRequest, CardGiftCardPaySubMerchantBindResponse>
    {
        /// <summary>
        /// 获取或设置微信支付子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;
    }
}
