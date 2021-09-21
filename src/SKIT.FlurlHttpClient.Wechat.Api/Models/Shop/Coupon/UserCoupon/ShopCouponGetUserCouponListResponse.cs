using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/get_usercoupon_list 接口的响应。</para>
    /// </summary>
    public class ShopCouponGetUserCouponListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class Extra
                    {
                        /// <summary>
                        /// 获取或设置用户优惠券核销时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_time")]
                        public long? UseTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家侧用户优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_user_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_user_coupon_id")]
                public string OutUserCouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家侧优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
                public string OutCouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置优惠券扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                public Types.Extra Extra { get; set; } = default!;

                /// <summary>
                /// 获取或设置有效开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
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
