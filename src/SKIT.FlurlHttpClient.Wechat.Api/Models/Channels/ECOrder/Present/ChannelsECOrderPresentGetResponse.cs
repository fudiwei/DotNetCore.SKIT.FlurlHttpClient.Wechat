namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/present/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderPresentGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PresentOrder
            {
                public static class Types
                {
                    public class PresentDetail
                    {
                        public static class Types
                        {
                            public class PriceInfo
                            {
                                /// <summary>
                                /// 获取或设置价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_price")]
                                public int Price { get; set; }
                            }

                            public class PayInfo
                            {
                                /// <summary>
                                /// 获取或设置支付时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                                public long PayTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置价格信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                        public Types.PriceInfo? PriceInfo { get; set; }

                        /// <summary>
                        /// 获取或设置支付信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_info")]
                        public Types.PayInfo? PayInfo { get; set; }

                        /// <summary>
                        /// 获取或设置祝福语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wishmessage")]
                        [System.Text.Json.Serialization.JsonPropertyName("wishmessage")]
                        public string? WishMessage { get; set; }
                    }

                    public class SubOrder
                    {
                        /// <summary>
                        /// 获取或设置子单订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收礼者 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置子单订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置礼物订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
                public string PresentOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否付款。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_b2c_free_present")]
                [System.Text.Json.Serialization.JsonPropertyName("is_b2c_free_present")]
                public bool IsB2CFreePresent { get; set; }

                /// <summary>
                /// 获取或设置礼物详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("present_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("present_detail")]
                public Types.PresentDetail PresentDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置子单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_order_list")]
                public Types.SubOrder[] SubOrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置关联活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? ActivityId { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置礼物订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present")]
        [System.Text.Json.Serialization.JsonPropertyName("present")]
        public Types.PresentOrder PresentOrder { get; set; } = default!;
    }
}
