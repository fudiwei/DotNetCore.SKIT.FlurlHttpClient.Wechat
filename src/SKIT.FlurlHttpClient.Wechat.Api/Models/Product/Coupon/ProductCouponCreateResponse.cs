namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/create 接口的响应。</para>
    /// </summary>
    public class ProductCouponCreateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                public int CouponId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
