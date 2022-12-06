namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /campaigns/get 接口的响应。</para>
    /// </summary>
    public class CampaignsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Campaign
                    {
                        /// <summary>
                        /// 获取或设置推广计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                        public long CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置推广计划名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
                        public string CampaignName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广计划类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_type")]
                        public string CampaignType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广标的物类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                        public string ProductType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("configured_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("configured_status")]
                        public string ConfiguredStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日消耗限额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("daily_budget")]
                        [System.Text.Json.Serialization.JsonPropertyName("daily_budget")]
                        public int? DailyBudget { get; set; }

                        /// <summary>
                        /// 获取或设置限额到达日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("budget_reach_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("budget_reach_date")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string? BudgetReachDateString { get; set; }

                        /// <summary>
                        /// 获取或设置最近修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_modified_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_modified_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("created_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                        public long CreateTimestamp { get; set; }
                    }

                    public class Pagination : Abstractions.CommonPagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置推广计划列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Campaign[] CampaignList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
