using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/create 接口的请求。</para>
    /// </summary>
    public class ProductCouponCreateRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Discount
            {
                public static class Types
                {
                    public class DiscountCondidtion
                    {
                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                        public int? ProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
                        public IList<long>? ProductIdList { get; set; }

                        /// <summary>
                        /// 获取或设置商品价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                        public int? ProductPrice { get; set; }
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

            public class Extra
            {
                /// <summary>
                /// 获取或设置领取后跳转的商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_product_id")]
                public long? JumpProductId { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notes")]
                [System.Text.Json.Serialization.JsonPropertyName("notes")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置有效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_time")]
                public long ValidTimestamp { get; set; }

                /// <summary>
                /// 获取或设置失效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invalid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("invalid_time")]
                public long InvalidTimestamp { get; set; }
            }

            public class Promotion
            {
                /// <summary>
                /// 获取或设置自定义推广渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customize_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("customize_channel")]
                public string CustomizeChannel { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置推广类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promote_type")]
                [System.Text.Json.Serialization.JsonPropertyName("promote_type")]
                public int PromoteType { get; set; }
            }

            public class Reception
            {
                /// <summary>
                /// 获取或设置单人限领数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit_num_one_person")]
                [System.Text.Json.Serialization.JsonPropertyName("limit_num_one_person")]
                public int? LimitPerUser { get; set; }

                /// <summary>
                /// 获取或设置领取总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_num")]
                public int? TotalNumber { get; set; }

                /// <summary>
                /// 获取或设置领取开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置领取结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }
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
        }

        /// <summary>
        /// 获取或设置优惠券类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

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
        /// 获取或设置扩展信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
        public Types.Extra? Extra { get; set; }

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
