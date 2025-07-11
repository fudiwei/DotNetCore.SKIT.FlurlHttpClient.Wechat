namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/talent/get_order_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECTalentGetOrderListRequest : WechatApiRequest, IInferable<ChannelsECTalentGetOrderListRequest, ChannelsECTalentGetOrderListResponse>
    {
        /// <summary>
        /// 获取或设置佣金单创建时间范围的开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_gt")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_gt")]
        public long? StartCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置佣金单创建时间范围的结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_lt")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_lt")]
        public long? EndCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置佣金单更新时间范围的开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_gt")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_gt")]
        public long? StartUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置佣金单更新时间范围的结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_lt")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_lt")]
        public long? EndUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置佣金单特殊标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("special_id")]
        [System.Text.Json.Serialization.JsonPropertyName("special_id")]
        public string? SpecialId { get; set; }

        /// <summary>
        /// 获取或设置 SPU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
        public string? SPUId { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
