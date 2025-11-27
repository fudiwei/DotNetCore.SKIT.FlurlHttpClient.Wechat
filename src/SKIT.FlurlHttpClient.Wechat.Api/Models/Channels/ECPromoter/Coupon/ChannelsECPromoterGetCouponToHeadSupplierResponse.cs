namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_to_headsupplier 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponToHeadSupplierResponse : WechatApiResponse
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
                /// 获取或设置接收的机构 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("to_head_supplier_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("to_head_supplier_appid")]
                public string ToHeadSupplierAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发放时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("give_time")]
                [System.Text.Json.Serialization.JsonPropertyName("give_time")]
                public long GiveTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Coupon[] CouponList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_context")]
        [System.Text.Json.Serialization.JsonPropertyName("page_context")]
        public string? NextCursor { get; set; }
    }
}
