namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_qr_code 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponQrcodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置优惠券推广二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
