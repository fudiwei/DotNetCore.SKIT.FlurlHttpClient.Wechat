using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /campaigns/add 接口的响应。</para>
    /// </summary>
    public class CampaignsAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置推广计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("campaign_id")]
                [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                public long CampaignId { get; set; }
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
