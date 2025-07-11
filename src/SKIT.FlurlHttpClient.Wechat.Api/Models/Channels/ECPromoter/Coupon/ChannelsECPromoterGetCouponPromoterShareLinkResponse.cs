namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_promoter_share_link 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponPromoterShareLinkResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置内嵌微信小店优惠券的推广参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_share_link")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_share_link")]
        public string PromoterShareLink { get; set; } = default!;
    }
}
