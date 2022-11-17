﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/get 接口的响应。</para>
    /// </summary>
    public class ShopCouponGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
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
                                                        public string OutProductId { get; set; } = default!;

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
                                                        public string BuyOutProductId { get; set; } = default!;

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
                                                        public string GetOutProductId { get; set; } = default!;

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
                                                public string[]? ProductIdList { get; set; }

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

                                    public class Reception
                                    {
                                        /// <summary>
                                        /// 获取或设置单人限领数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("limit_num_one_person")]
                                        [System.Text.Json.Serialization.JsonPropertyName("limit_num_one_person")]
                                        public int LimitPerUser { get; set; }

                                        /// <summary>
                                        /// 获取或设置领取总数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
                                        public int TotalCount { get; set; }

                                        /// <summary>
                                        /// 获取或设置领取开始时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("start_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                        public long StartTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置领取结束时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("end_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                        public long EndTimestamp { get; set; }
                                    }

                                    public class Validity
                                    {
                                        /// <summary>
                                        /// 获取或设置有效期类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("valid_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("valid_type")]
                                        public int ValidType { get; set; }

                                        /// <summary>
                                        /// 获取或设置相对生效天数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("valid_day_num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("valid_day_num")]
                                        public int? ValidDays { get; set; }

                                        /// <summary>
                                        /// 获取或设置相对生效秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("valid_second")]
                                        [System.Text.Json.Serialization.JsonPropertyName("valid_second")]
                                        public int? ValidSeconds { get; set; }

                                        /// <summary>
                                        /// 获取或设置绝对生效开始时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("start_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                        public long? StartTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置绝对生效结束时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("end_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                        public long? EndTimestamp { get; set; }
                                    }

                                    public class Extra
                                    {
                                        /// <summary>
                                        /// 获取或设置有效期时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("valid_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("valid_time")]
                                        public long? ValidTimestamp { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置优惠券名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置优惠信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_info")]
                                public Types.Discount Discount { get; set; } = default!;

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
                                public Types.Validity? Validity { get; set; }

                                /// <summary>
                                /// 获取或设置优惠券扩展信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ext_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                                public Types.Extra? Extra { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商家侧优惠券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_coupon_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
                        public string OutCouponId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? AppId { get; set; }

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
                        public Types.CouponDetail CouponDetail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠券状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon")]
                public Types.Coupon Coupon { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result Result { get; set; } = default!;
    }
}
