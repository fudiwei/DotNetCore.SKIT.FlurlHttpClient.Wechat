using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/get_list 接口的请求。</para>
    /// </summary>
    public class ShopOrderGetListRequest : WechatApiRequest, IInferable<ShopOrderGetListRequest, ShopOrderGetListResponse>
    {
        /// <summary>
        /// 获取或设置创建时间的开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset? StartCreateTime { get; set; }

        /// <summary>
        /// 获取或设置创建时间的结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset? EndCreateTime { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_order")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int SortType { get; set; } = 1;

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
