using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueItemGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Item
            {
                public static class Types
                {
                    public class ExclusiveInfo
                    {
                        /// <summary>
                        /// 获取或设置特殊推广商品计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("info_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("info_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? InfoId { get; set; }

                        /// <summary>
                        /// 获取或设置推广达人视频号唯一标识列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finder_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("finder_ids")]
                        public string[]? FinderIdList { get; set; }

                        /// <summary>
                        /// 获取或设置推广达人总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finder_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("finder_num")]
                        public int? FinderTotalCount { get; set; }

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
                        public bool IsForerver { get; set; }
                    }

                    public class ExtendedInfo
                    {
                        /// <summary>
                        /// 获取或设置是否类目禁售。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_sale_forbidden")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_sale_forbidden")]
                        public bool IsSaleForbidden { get; set; }

                        /// <summary>
                        /// 获取或设置是否被官方封禁。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_banned")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_banned")]
                        public bool IsBanned { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品推广类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? ProductId { get; set; }

                /// <summary>
                /// 获取或设置分佣率（范围：0～100）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                public int? Ratio { get; set; }

                /// <summary>
                /// 获取或设置商品推广状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置特殊推广信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exclusive_info")]
                [System.Text.Json.Serialization.JsonPropertyName("exclusive_info")]
                public Types.ExclusiveInfo? ExclusiveInfo { get; set; }

                /// <summary>
                /// 获取或设置扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                public Types.ExtendedInfo? ExtendedInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置联盟商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Item Item { get; set; } = default!;
    }
}
