namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_product_promotion_qrcode_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetProductPromotionQrcodeInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品推广二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
