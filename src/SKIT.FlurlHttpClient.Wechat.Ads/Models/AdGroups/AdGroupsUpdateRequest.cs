namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /adgroups/update 接口的请求。</para>
    /// </summary>
    public class AdGroupsUpdateRequest : WechatAdsRequest
    {
        public static class Types
        {
            public class Target : AdGroupsAddRequest.Types.Target
            {
            }
        }

        /// <summary>
        /// 获取或设置广告组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adgroup_id")]
        [System.Text.Json.Serialization.JsonPropertyName("adgroup_id")]
        public long AdGroupId { get; set; }

        /// <summary>
        /// 获取或设置广告组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adgroup_name")]
        [System.Text.Json.Serialization.JsonPropertyName("adgroup_name")]
        public string? AdGroupName { get; set; }

        /// <summary>
        /// 获取或设置定向条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("targeting")]
        [System.Text.Json.Serialization.JsonPropertyName("targeting")]
        public Types.Target? Target { get; set; }

        /// <summary>
        /// 获取或设置广告出价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bid_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("bid_amount")]
        public int? BidAmount { get; set; }

        /// <summary>
        /// 获取或设置开始投放日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_date")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
        public string? BeginDateString { get; set; }

        /// <summary>
        /// 获取或设置结束投放日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string? EndDateString { get; set; }

        /// <summary>
        /// 获取或设置投放时间段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_series")]
        [System.Text.Json.Serialization.JsonPropertyName("time_series")]
        public string? TimeSeries { get; set; }

        /// <summary>
        /// 获取或设置日限额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("daily_budget")]
        [System.Text.Json.Serialization.JsonPropertyName("daily_budget")]
        public int? DailyBudget { get; set; }

        /// <summary>
        /// 获取或设置广告状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("configured_status")]
        [System.Text.Json.Serialization.JsonPropertyName("configured_status")]
        public string? ConfiguredStatus { get; set; }
    }
}
