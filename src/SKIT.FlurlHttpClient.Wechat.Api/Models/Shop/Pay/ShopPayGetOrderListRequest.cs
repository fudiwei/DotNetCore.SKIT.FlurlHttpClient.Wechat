namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/getorderlist 接口的请求。</para>
    /// </summary>
    public class ShopPayGetOrderListRequest : WechatApiRequest, IInferable<ShopPayGetOrderListRequest, ShopPayGetOrderListResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_index")]
        [System.Text.Json.Serialization.JsonPropertyName("last_index")]
        public string? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置起始创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_create_time")]
        public long? StartCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置截止创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_create_time")]
        public long? EndCreateTimestamp { get; set; }
    }
}
