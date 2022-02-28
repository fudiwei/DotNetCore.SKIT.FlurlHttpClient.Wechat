using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/get_list_by_sharer 接口的请求。</para>
    /// </summary>
    public class ShopOrderGetListBySharerRequest : WechatApiRequest, IInferable<ShopOrderGetListBySharerRequest, ShopOrderGetListBySharerResponse>
    {
        /// <summary>
        /// 获取或设置支付时间的开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartPayTime { get; set; }

        /// <summary>
        /// 获取或设置支付时间的结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndPayTime { get; set; }

        /// <summary>
        /// 获取或设置分享者的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
        public string? SharerOpenId { get; set; }

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
