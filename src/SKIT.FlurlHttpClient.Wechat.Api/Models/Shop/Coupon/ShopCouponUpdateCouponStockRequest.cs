namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/update_coupon_stock 接口的请求。</para>
    /// </summary>
    public class ShopCouponUpdateCouponStockRequest : WechatApiRequest
    {
        public static class Types
        {
            public class CouponStock
            {
                public static class Types
                {
                    public class Stock
                    {
                        /// <summary>
                        /// 获取或设置剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("issued_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("issued_num")]
                        public int IssuedNumber { get; set; }

                        /// <summary>
                        /// 获取或设置发放量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_num")]
                        public int ReceiveNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商家侧优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
                public string OutCouponId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_info")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_info")]
                public Types.Stock Stock { get; set; } = new Types.Stock();
            }
        }

        /// <summary>
        /// 获取或设置优惠券库存信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_stock")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_stock")]
        public Types.CouponStock CouponStock { get; set; } = new Types.CouponStock();
    }
}
