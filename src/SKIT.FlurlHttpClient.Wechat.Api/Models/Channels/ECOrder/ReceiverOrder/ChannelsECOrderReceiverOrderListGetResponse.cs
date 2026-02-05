namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/receiverorderlist/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderReceiverOrderListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PresentOrder
            {
                /// <summary>
                /// 获取或设置礼物订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PresentOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置子单订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置礼物订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.PresentOrder[] PresentOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
