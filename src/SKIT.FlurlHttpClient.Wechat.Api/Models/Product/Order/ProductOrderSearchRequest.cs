using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/search 接口的请求。</para>
    /// </summary>
    public class ProductOrderSearchRequest : WechatApiRequest, IMapResponse<ProductOrderSearchRequest, ProductOrderSearchResponse>
    {
        /// <summary>
        /// 获取或设置指定付款时间的开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartPayTime { get; set; }

        /// <summary>
        /// 获取或设置指定付款时间的结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndPayTime { get; set; }

        /// <summary>
        /// 获取或设置指定商品标题关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? TitleKeyword { get; set; }

        /// <summary>
        /// 获取或设置指定商品编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_code")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
        public string? SKUCode { get; set; }

        /// <summary>
        /// 获取或设置指定收件人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string? ReceiverName { get; set; }

        /// <summary>
        /// 获取或设置指定收件人电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tel_number")]
        [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
        public string? ReceiverTeleNumber { get; set; }

        /// <summary>
        /// 获取或设置指定订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 获取或设置指定订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置指定订单售后状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("on_aftersale_order_exist")]
        [System.Text.Json.Serialization.JsonPropertyName("on_aftersale_order_exist")]
        public int? AftersaleStatus { get; set; }

        /// <summary>
        /// 获取或设置指定订单来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public int? Source { get; set; }

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
