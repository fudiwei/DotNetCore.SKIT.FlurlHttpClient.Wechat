using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /campaigns/add 接口的请求。</para>
    /// </summary>
    public class CampaignsAddRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置推广计划名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_name")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
        public string CampaignName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推广计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_type")]
        public string CampaignType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推广标的物类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public string ProductType { get; set; } = string.Empty;

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
