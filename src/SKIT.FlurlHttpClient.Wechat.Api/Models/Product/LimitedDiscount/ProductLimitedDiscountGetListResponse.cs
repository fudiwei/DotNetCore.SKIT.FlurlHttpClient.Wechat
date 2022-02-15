namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/limiteddiscount/get_list 接口的响应。</para>
    /// </summary>
    public class ProductLimitedDiscountGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Task
            {
                public static class Types
                {
                    public class SKU : ProductLimitedDiscountAddRequest.Types.SKU
                    {
                    }
                }

                /// <summary>
                /// 获取或设置抢购任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public int TaskId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

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
                [Newtonsoft.Json.JsonProperty("limited_discount_sku_list")]
                [System.Text.Json.Serialization.JsonPropertyName("limited_discount_sku_list")]
                public Types.SKU[] SKUList { get; set; } = default!;

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
            }
        }

        /// <summary>
        /// 获取或设置抢购任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limited_discount_list")]
        [System.Text.Json.Serialization.JsonPropertyName("limited_discount_list")]
        public Types.Task[] TaskList { get; set; } = default!;
    }
}
