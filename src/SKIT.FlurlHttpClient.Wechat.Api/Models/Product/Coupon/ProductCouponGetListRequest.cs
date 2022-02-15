using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/get_list 接口的请求。</para>
    /// </summary>
    public class ProductCouponGetListRequest : WechatApiRequest, IMapResponse<ProductCouponGetListRequest, ProductCouponGetListResponse>
    {
        /// <summary>
        /// 获取或设置指定创建时间的开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartCreateTime { get; set; }

        /// <summary>
        /// 获取或设置指定创建时间的结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndCreateTime { get; set; }

        /// <summary>
        /// 获取或设置指定优惠券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
