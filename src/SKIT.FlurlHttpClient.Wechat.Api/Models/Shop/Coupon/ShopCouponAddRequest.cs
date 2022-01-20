using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/add 接口的请求。</para>
    /// </summary>
    public class ShopCouponAddRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Coupon
            {
                public static class Types
                {
                    public class CouponDetail
                    {
                        public static class Types
                        {
                            public class Discount
                            {
                                public static class Types
                                {
                                    public class DiscountCondidtion
                                    {
                                        public static class Types
                                        {
                                            public class TradeIn
                                            {
                                                /// <summary>
                                                /// 获取或设置商家自定义商品 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("out_product_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                                                public string OutProductId { get; set; } = string.Empty;

                                                /// <summary>
                                                /// 获取或设置换购金额（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("price")]
                                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                                public int Price { get; set; }
                                            }

                                            public class BuyGet
                                            {
                                                /// <summary>
                                                /// 获取或设置购买的商家自定义商品 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("buy_out_product_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("buy_out_product_id")]
                                                public string BuyOutProductId { get; set; } = string.Empty;

                                                /// <summary>
                                                /// 获取或设置购买的商品数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("buy_product_cnt")]
                                                [System.Text.Json.Serialization.JsonPropertyName("buy_product_cnt")]
                                                public int BuyProductCount { get; set; }

                                                /// <summary>
                                                /// 获取或设置赠送的商家自定义商品 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("get_out_product_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("get_out_product_id")]
                                                public string GetOutProductId { get; set; } = string.Empty;

                                                /// <summary>
                                                /// 获取或设置赠送的商品数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("get_product_cnt")]
                                                [System.Text.Json.Serialization.JsonPropertyName("get_product_cnt")]
                                                public int GetProductCount { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置商品数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_cnt")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                                        public int? ProductCount { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品价格（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                                        public int? ProductPrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家自定义商品 ID 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("out_product_ids")]
                                        [System.Text.Json.Serialization.JsonPropertyName("out_product_ids")]
                                        public IList<string>? ProductIdList { get; set; }

                                        /// <summary>
                                        /// 获取或设置换购信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tradein_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tradein_info")]
                                        public Types.TradeIn? TradeIn { get; set; }

                                        /// <summary>
                                        /// 获取或设置买赠券信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("buyget_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("buyget_info")]
                                        public Types.BuyGet? BuyGet { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置优惠条件信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_condition")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_condition")]
                                public Types.DiscountCondidtion? DiscountCondidtion { get; set; }

                                /// <summary>
                                /// 获取或设置满减金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_fee")]
                                public int? DiscountFee { get; set; }

                                /// <summary>
                                /// 获取或设置折扣数值（范围：1000～10000）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_num")]
                                public int? DiscountNumber { get; set; }
                            }

                            public class Promotion
                            {
                                public static class Types
                                {
                                    public class Finder
                                    {
                                        /// <summary>
                                        /// 获取或设置视频号昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                        public string? Nickname { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置推广类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promote_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("promote_type")]
                                public int PromoteType { get; set; }

                                /// <summary>
                                /// 获取或设置推广视频号信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder")]
                                public Types.Finder? Finder { get; set; }
                            }

                            public class Reception : ProductCouponCreateRequest.Types.Reception
                            {
                            }

                            public class Validity : ProductCouponCreateRequest.Types.Validity
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置优惠券名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置优惠信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_info")]
                        public Types.Discount Discount { get; set; } = new Types.Discount();

                        /// <summary>
                        /// 获取或设置推广信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promote_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("promote_info")]
                        public Types.Promotion? Promotion { get; set; }

                        /// <summary>
                        /// 获取或设置接收信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_info")]
                        public Types.Reception? Reception { get; set; }

                        /// <summary>
                        /// 获取或设置有效期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_info")]
                        public Types.Validity Validity { get; set; } = new Types.Validity();
                    }
                }

                /// <summary>
                /// 获取或设置商家侧优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
                public string OutCouponId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优惠券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置优惠券推广类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promote_type")]
                [System.Text.Json.Serialization.JsonPropertyName("promote_type")]
                public int PromoteType { get; set; }

                /// <summary>
                /// 获取或设置优惠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                public Types.CouponDetail CouponDetail { get; set; } = new Types.CouponDetail();
            }
        }

        /// <summary>
        /// 获取或设置优惠券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon")]
        public Types.Coupon Coupon { get; set; } = new Types.Coupon();
    }
}
