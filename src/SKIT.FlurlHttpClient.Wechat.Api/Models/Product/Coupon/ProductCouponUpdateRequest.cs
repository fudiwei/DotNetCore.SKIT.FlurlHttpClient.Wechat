using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/update 接口的请求。</para>
    /// </summary>
    public class ProductCouponUpdateRequest : WechatApiRequest, IMapResponse<ProductCouponUpdateRequest, ProductCouponUpdateResponse>
    {
        public static class Types
        {
            public class Discount : ProductCouponCreateRequest.Types.Discount
            {
            }

            public class Extra : ProductCouponCreateRequest.Types.Extra
            {
            }

            public class Promotion : ProductCouponCreateRequest.Types.Promotion
            {
            }

            public class Reception : ProductCouponCreateRequest.Types.Reception
            {
            }

            public class Validity : ProductCouponCreateRequest.Types.Validity
            {
            }
        }

        /// <summary>
        /// 获取或设置优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public int CouponId { get; set; }

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
