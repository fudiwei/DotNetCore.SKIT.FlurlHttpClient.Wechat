using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/limiteddiscounttask/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductLimitedDiscountTaskUpdateRequest : WechatApiRequest, IInferable<ChannelsECProductLimitedDiscountTaskUpdateRequest, ChannelsECProductLimitedDiscountTaskUpdateResponse>
    {
        public static class Types
        {
            public class SKU : ChannelsECProductLimitedDiscountTaskAddRequest.Types.SKU
            {
                /// <summary>
                /// 获取或设置所属商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置抢购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }

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
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置抢购任务开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limited_discount_skus")]
        [System.Text.Json.Serialization.JsonPropertyName("limited_discount_skus")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();

        /// <summary>
        /// 获取或设置活动状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }
    }
}
