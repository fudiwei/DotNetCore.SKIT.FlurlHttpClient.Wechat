namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_cooperative_coupon_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCooperativeCouponListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon
            {
                /// <summary>
                /// 获取或设置券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CouponId { get; set; }

                /// <summary>
                /// 获取或设置来源的机构 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from_head_supplier_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("from_head_supplier_appid")]
                public string? FromHeadSupplierAppId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("coupons")]
        public Types.Coupon[] CouponList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
