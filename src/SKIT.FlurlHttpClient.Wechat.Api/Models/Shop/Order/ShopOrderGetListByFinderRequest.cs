namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/get_list_by_finder 接口的请求。</para>
    /// </summary>
    public class ShopOrderGetListByFinderRequest : WechatApiRequest, IInferable<ShopOrderGetListByFinderRequest, ShopOrderGetListByFinderResponse>
    {
        /// <summary>
        /// 获取或设置支付时间的开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.ISO8601DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.ISO8601DateTimeOffsetConverter))]
        public DateTimeOffset? StartPayTime { get; set; }

        /// <summary>
        /// 获取或设置支付时间的结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.ISO8601DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.ISO8601DateTimeOffsetConverter))]
        public DateTimeOffset? EndPayTime { get; set; }

        /// <summary>
        /// 获取或设置推广员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
        public string? PromoterId { get; set; }

        /// <summary>
        /// 获取或设置推广员 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_openid")]
        public string? PromoterOpenId { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
