using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /realtime_cost/get 接口的响应。</para>
    /// </summary>
    public class RealtimeCostGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class RealtimeCost
                    {
                        /// <summary>
                        /// 获取或设置推广计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                        public long CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置广告组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adgroup_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("adgroup_id")]
                        public long AdGroupId { get; set; }

                        /// <summary>
                        /// 获取或设置消耗金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost")]
                        public int Cost { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置实时消耗列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.RealtimeCost[] RealtimeCostList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Abstractions.CommonPagination Pagination { get; set; } = default!;
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
