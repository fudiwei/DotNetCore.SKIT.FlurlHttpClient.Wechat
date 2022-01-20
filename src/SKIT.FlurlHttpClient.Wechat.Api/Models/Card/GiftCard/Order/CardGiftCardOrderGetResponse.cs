namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/order/get 接口的响应。</para>
    /// </summary>
    public class CardGiftCardOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class Card
                    {
                        /// <summary>
                        /// 获取或设置卡券模板编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                        public string CardId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卡券 Code。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string CardCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卡券价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置背景图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("background_pic_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("background_pic_url")]
                        public string BackgroundPictureUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置自定义卡面标识 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outer_img_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("outer_img_id")]
                        public string? OuterImageUrl { get; set; }

                        /// <summary>
                        /// 获取或设置默认祝福语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("default_gifting_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("default_gifting_msg")]
                        public string? DefaultGiftingMessage { get; set; }

                        /// <summary>
                        /// 获取或设置接收者的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("accepter_openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("accepter_openid")]
                        public string? AccepterOpenId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置货架 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_id")]
                [System.Text.Json.Serialization.JsonPropertyName("page_id")]
                public string PageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付交易订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trans_id")]
                [System.Text.Json.Serialization.JsonPropertyName("trans_id")]
                public string TransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置购买者的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收者的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("accepter_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("accepter_openid")]
                public string? AccepterOpenId { get; set; }

                /// <summary>
                /// 获取或设置全部金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_price")]
                [System.Text.Json.Serialization.JsonPropertyName("total_price")]
                public int TotalFee { get; set; }

                /// <summary>
                /// 获取或设置是否是群转增。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("IsChatRoom")]
                [System.Text.Json.Serialization.JsonPropertyName("IsChatRoom")]
                public bool? IsFromChatroom { get; set; }

                /// <summary>
                /// 获取或设置礼品卡列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_list")]
                [System.Text.Json.Serialization.JsonPropertyName("card_list")]
                public Types.Card[] Card { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付完成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_finish_time")]
                public long? PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置商户自定义字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outer_str")]
                [System.Text.Json.Serialization.JsonPropertyName("outer_str")]
                public string? OuterString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
