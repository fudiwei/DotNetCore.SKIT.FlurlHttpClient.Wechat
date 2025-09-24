namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/product-coupons/send 接口的响应。</para>
    /// </summary>
    public class SendMarketingBusifavorProductCouponResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public string StockId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户单据号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
                public string OutRequestNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家券 Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
                public string CouponCode { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置发券结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_coupon_result")]
        [System.Text.Json.Serialization.JsonPropertyName("send_coupon_result")]
        public Types.Result Result { get; set; } = default!;
    }
}
