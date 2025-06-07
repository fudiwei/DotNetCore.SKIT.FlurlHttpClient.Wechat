namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_short_link 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponShortLinkResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置优惠券推广短链。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_link")]
        [System.Text.Json.Serialization.JsonPropertyName("short_link")]
        public string ShortLink { get; set; } = default!;
    }
}
