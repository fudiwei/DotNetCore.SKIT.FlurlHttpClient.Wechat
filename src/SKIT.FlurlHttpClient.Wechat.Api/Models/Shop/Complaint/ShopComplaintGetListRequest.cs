namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/complaint/get_list 接口的请求。</para>
    /// </summary>
    public class ShopComplaintGetListRequest : WechatApiRequest, IInferable<ShopComplaintGetListRequest, ShopComplaintGetListResponse>
    {
        /// <summary>
        /// 获取或设置纠纷单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public int? State { get; set; }

        /// <summary>
        /// 获取或设置纠纷单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置申请时间开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_create_time")]
        public long? BeginCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置申请时间截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_create_time")]
        public long? EndCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置关联订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 获取或设置关联售后单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public long? AftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;
    }
}
