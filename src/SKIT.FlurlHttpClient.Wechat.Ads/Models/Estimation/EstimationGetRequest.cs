using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /estimation/get 接口的请求。</para>
    /// </summary>
    public class EstimationGetRequest : WechatAdsRequest
    {
        public static class Types
        {
            public class Target : AdGroupsAddRequest.Types.Target
            {
            }
        }

        /// <summary>
        /// 获取或设置推广计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_type")]
        public string CampaignType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置定向条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("targeting")]
        [System.Text.Json.Serialization.JsonPropertyName("targeting")]
        public Types.Target Target { get; set; } = new Types.Target();
    }
}
