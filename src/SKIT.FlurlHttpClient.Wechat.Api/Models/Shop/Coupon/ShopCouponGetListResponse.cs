using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/get_list 接口的响应。</para>
    /// </summary>
    public class ShopCouponGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class Coupon : ShopCouponGetResponse.Types.Result.Types.Coupon
                    { 
                    }

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
                        public string OutCouponId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置库存信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_info")]
                        public Types.Stock Stock { get; set; } = default!;

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

                /// <summary>
                /// 获取或设置优惠券库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_stock")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_stock")]
                public Types.CouponStock CouponStock { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_list")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
