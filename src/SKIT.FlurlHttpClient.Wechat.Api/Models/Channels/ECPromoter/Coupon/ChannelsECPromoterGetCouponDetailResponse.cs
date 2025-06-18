namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_detail 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon : ChannelsECCouponGetResponse.Types.Coupon
            {
            }
        }

        /// <summary>
        /// 获取或设置券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon")]
        public Types.Coupon Coupon { get; set; } = default!;
    }
}
