namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /ads/get 接口的响应。</para>
    /// </summary>
    public class AdsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Ad
                    {
                        public static class Types
                        {
                            public class AdCreative : AdCreativesGetResponse.Types.Data.Types.AdCreative
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置推广计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                        public long CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置广告 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                        public long AdId { get; set; }

                        /// <summary>
                        /// 获取或设置广告名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_name")]
                        public string AdName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adgroup_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("adgroup_id")]
                        public long AdGroupId { get; set; }

                        /// <summary>
                        /// 获取或设置广告创意信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adcreative")]
                        [System.Text.Json.Serialization.JsonPropertyName("adcreative")]
                        public Types.AdCreative AdCreative { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("configured_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("configured_status")]
                        public string ConfiguredStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置系统状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("system_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("system_status")]
                        public string SystemStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_message")]
                        public string? RejectReason { get; set; }

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
                /// 获取或设置广告列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Ad[] AdList { get; set; } = default!;

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
