namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/limiteddiscounttask/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductLimitedDiscountTaskListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LimitedDiscountTask
            {
                public static class Types
                {
                    public class SKU : ProductLimitedDiscountAddRequest.Types.SKU
                    {
                        /// <summary>
                        /// 获取或设置所属商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置剩余抢购库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remaining_stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("remaining_stock")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int RemainingStock { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置抢购任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long TaskId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置活动名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置抢购任务开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置抢购任务开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limited_discount_skus")]
                [System.Text.Json.Serialization.JsonPropertyName("limited_discount_skus")]
                public Types.SKU[] SKUList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否开启限购。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_limit_purchase")]
                [System.Text.Json.Serialization.JsonPropertyName("is_limit_purchase")]
                public bool? IsLimitedPurchase { get; set; }

                /// <summary>
                /// 获取或设置限购数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit_purchase_num")]
                [System.Text.Json.Serialization.JsonPropertyName("limit_purchase_num")]
                public int? LimitedPurchaseCount { get; set; }

                /// <summary>
                /// 获取或设置抢购任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置活动支付 GMV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_pay_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_pay_gmv")]
                public int DiscountPayGMV { get; set; }

                /// <summary>
                /// 获取或设置活动支付 GMV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_pay_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_pay_uv")]
                public int DiscountPayUV { get; set; }

                /// <summary>
                /// 获取或设置活动支付订单数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_pay_order_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_pay_order_cnt")]
                public int DiscountPayOrderCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置抢购任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limited_discount_tasks")]
        [System.Text.Json.Serialization.JsonPropertyName("limited_discount_tasks")]
        public Types.LimitedDiscountTask[] LimitedDiscountTaskList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
