namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/order/batchget 接口的响应。</para>
    /// </summary>
    public class CardGiftCardOrderBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : CardGiftCardOrderGetResponse.Types.__zz__Order
            {
                public static class Types
                {
                    public class Card : CardGiftCardOrderGetResponse.Types.Order.Types.Card
                    {
                    }
                }

                /// <summary>
                /// 获取或设置礼品卡列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_list")]
                [System.Text.Json.Serialization.JsonPropertyName("card_list")]
                public List<Types.Card>? Card { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public List<Types.Order>? OrderList { get; set; }

        /// <summary>
        /// 获取或设置订单总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
