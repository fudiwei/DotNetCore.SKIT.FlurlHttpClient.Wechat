namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_api/get_order 接口的响应。</para>
    /// </summary>
    public class CgibinAdvancedApiGetOrderResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class ChatArchiveApi
                    {
                        /// <summary>
                        /// 获取或设置版本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("edition")]
                        [System.Text.Json.Serialization.JsonPropertyName("edition")]
                        public int Edition { get; set; }

                        /// <summary>
                        /// 获取或设置购买数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("purchase_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("purchase_count")]
                        public int PurchaseCount { get; set; }

                        /// <summary>
                        /// 获取或设置购买天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("purchase_duration_days")]
                        [System.Text.Json.Serialization.JsonPropertyName("purchase_duration_days")]
                        public int PurchaseDurationDays { get; set; }

                        /// <summary>
                        /// 获取或设置生效时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("take_effect_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("take_effect_time")]
                        public long TakeEffectTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置到期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置原价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                        public int? OriginalPrice { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置购买的高级接口类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advanced_api_type")]
                [System.Text.Json.Serialization.JsonPropertyName("advanced_api_type")]
                public int AdvancedApiType { get; set; }

                /// <summary>
                /// 获取或设置客户企业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_corpid")]
                public string CustomCorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_userid")]
                public string BuyerUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置应付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_price")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_price")]
                public int PaidPrice { get; set; }

                /// <summary>
                /// 获取或设置会话内容数据接口订单相关信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_archive_api")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_archive_api")]
                public Types.ChatArchiveApi? ChatArchiveApi { get; set; }
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
