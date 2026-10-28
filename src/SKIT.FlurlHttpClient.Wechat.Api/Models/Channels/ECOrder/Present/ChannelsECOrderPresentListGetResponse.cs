namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentlist/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderPresentListGetResponse : WechatApiResponse
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
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? PresentOrderId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置礼物订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_list")]
        public List<Types.PresentOrder>? PresentOrderList { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
