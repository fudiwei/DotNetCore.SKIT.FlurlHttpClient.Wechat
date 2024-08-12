namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /multiuse/users/{openid}/coupons 接口的响应。</para>
    /// </summary>
    public class SendMultiuseUserCouponResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置消费金 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public string CouponId { get; set; } = default!;
    }
}
