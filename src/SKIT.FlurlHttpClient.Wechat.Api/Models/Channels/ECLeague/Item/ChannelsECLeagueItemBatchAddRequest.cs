using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/batchadd 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueItemBatchAddRequest : WechatApiRequest, IInferable<ChannelsECLeagueItemBatchAddRequest, ChannelsECLeagueItemBatchAddResponse>
    {
        public static class Types
        {
            public class Item
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置分佣率（范围：0～100）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                public int? Ratio { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品推广类别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置联盟商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public IList<Types.Item> List { get; set; } = new List<Types.Item>();

        /// <summary>
        /// 获取或设置视频号 ID列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_ids")]
        public IList<string>? FinderIdList { get; set; }

        /// <summary>
        /// 获取或设置推广开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置推广开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置是否永久推广。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_forerver")]
        [System.Text.Json.Serialization.JsonPropertyName("is_forerver")]
        public bool? IsForerver { get; set; }
    }
}
