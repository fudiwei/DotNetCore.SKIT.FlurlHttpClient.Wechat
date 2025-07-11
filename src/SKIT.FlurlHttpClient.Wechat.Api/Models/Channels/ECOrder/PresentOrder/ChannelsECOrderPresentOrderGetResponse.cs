namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentorder/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderPresentOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PresentOrder
            {
                public static class Types
                {
                    public class ECGiftInfo
                    {
                        public static class Types
                        {
                            public class GiftList
                            {
                                /// <summary>
                                /// 获取或设置礼品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gift")]
                                [System.Text.Json.Serialization.JsonPropertyName("gift")]
                                public GiftItem[] Items { get; set; } = default!;
                            }

                            public class GiftItem
                            {
                                /// <summary>
                                /// 获取或设置礼物订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string PresentOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置礼物状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("giftstatus")]
                                [System.Text.Json.Serialization.JsonPropertyName("giftstatus")]
                                public int GiftStatus { get; set; }

                                /// <summary>
                                /// 获取或设置祝福语。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wishmessage")]
                                [System.Text.Json.Serialization.JsonPropertyName("wishmessage")]
                                public string? WishMessage { get; set; }

                                /// <summary>
                                /// 获取或设置过期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("expired_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("expired_time")]
                                public long? ExpireTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置礼品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gifts")]
                        [System.Text.Json.Serialization.JsonPropertyName("gifts")]
                        public Types.GiftList GiftList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户视角类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                        public int UserType { get; set; }

                        /// <summary>
                        /// 获取或设置祝福语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wishmessage")]
                        [System.Text.Json.Serialization.JsonPropertyName("wishmessage")]
                        public string? WishMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置礼物信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ecsgift")]
                [System.Text.Json.Serialization.JsonPropertyName("ecsgift")]
                public Types.ECGiftInfo ECGiftInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否不能收礼。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cannot_receive")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("cannot_receive")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsCannotReceive { get; set; }

                /// <summary>
                /// 获取或设置不能收礼原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cannot_receive_tips")]
                [System.Text.Json.Serialization.JsonPropertyName("cannot_receive_tips")]
                public string? CannotReceiveTips { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置礼物订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_info")]
        public Types.PresentOrder PresentOrder { get; set; } = default!;
    }
}
