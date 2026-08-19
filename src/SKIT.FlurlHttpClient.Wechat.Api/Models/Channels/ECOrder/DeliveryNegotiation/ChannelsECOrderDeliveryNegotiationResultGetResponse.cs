namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/deliverynegotiation/result/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryNegotiationResultGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Negotiation
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置原发货时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("original_delivery_time")]
                public long OriginalDeliveryTimestamp { get; set; }

                /// <summary>
                /// 获取或设置预计发货时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("predict_delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("predict_delivery_time")]
                public long PredictDeliveryTimestamp { get; set; }

                /// <summary>
                /// 获取或设置协商原因类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public int ReasonType { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置截止处理时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deadline")]
                [System.Text.Json.Serialization.JsonPropertyName("deadline")]
                public long DeadlineTimestamp { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置协商结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("negotiation_list")]
        [System.Text.Json.Serialization.JsonPropertyName("negotiation_list")]
        public Types.Negotiation[] NegotiationList { get; set; } = default!;
    }
}
