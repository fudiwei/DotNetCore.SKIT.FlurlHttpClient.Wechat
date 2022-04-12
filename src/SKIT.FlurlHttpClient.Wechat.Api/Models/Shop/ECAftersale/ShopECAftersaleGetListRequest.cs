namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/get_list 接口的请求。</para>
    /// </summary>
    public class ShopECAftersaleGetListRequest : WechatApiRequest, IInferable<ShopECAftersaleGetListRequest, ShopECAftersaleGetListResponse>
    {
        /// <summary>
        /// 获取或设置售后单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

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
        /// 获取或设置关联商家自定义订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string? OutOrderId { get; set; }

        /// <summary>
        /// 获取或设置关联订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

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
