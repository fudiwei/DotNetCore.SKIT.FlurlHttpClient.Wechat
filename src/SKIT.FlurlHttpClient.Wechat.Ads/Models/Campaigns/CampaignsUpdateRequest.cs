namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /campaigns/update 接口的请求。</para>
    /// </summary>
    public class CampaignsUpdateRequest : WechatAdsRequest
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
        public string? CampaignName { get; set; }

        /// <summary>
        /// 获取或设置广告状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("configured_status")]
        [System.Text.Json.Serialization.JsonPropertyName("configured_status")]
        public string? ConfiguredStatus { get; set; }

        /// <summary>
        /// 获取或设置日消耗限额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("daily_budget")]
        [System.Text.Json.Serialization.JsonPropertyName("daily_budget")]
        public int? DailyBudget { get; set; }
    }
}
