namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /adgroups/get 接口的响应。</para>
    /// </summary>
    public class AdGroupsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AdGroup
                    {
                        public class Types
                        {
                            public class Target
                            {
                                public static class Types
                                {
                                    public class GeoLocation
                                    {
                                        public static class Types
                                        {
                                            public class CustomLocation
                                            {
                                                /// <summary>
                                                /// 获取或设置经度。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("longitude")]
                                                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                                                public double Longitude { get; set; }

                                                /// <summary>
                                                /// 获取或设置纬度。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("latitude")]
                                                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                                                public double Latitude { get; set; }

                                                /// <summary>
                                                /// 获取或设置半径（单位：米）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("radius")]
                                                [System.Text.Json.Serialization.JsonPropertyName("radius")]
                                                public int Radius { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置地点类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("location_types")]
                                        [System.Text.Json.Serialization.JsonPropertyName("location_types")]
                                        public string[] LocationTypes { get; set; } = new string[0];

                                        /// <summary>
                                        /// 获取或设置省市区县 ID 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("regions")]
                                        [System.Text.Json.Serialization.JsonPropertyName("regions")]
                                        public int[]? RegionIds { get; set; }

                                        /// <summary>
                                        /// 获取或设置商圈 ID 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("business_districts")]
                                        [System.Text.Json.Serialization.JsonPropertyName("business_districts")]
                                        public int[]? BusinessDistrictIds { get; set; }

                                        /// <summary>
                                        /// 获取或设置自定义地理位置列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("custom_locations")]
                                        [System.Text.Json.Serialization.JsonPropertyName("custom_locations")]
                                        public Types.CustomLocation[]? CustomLocations { get; set; }
                                    }

                                    public class WechatAdBehavior
                                    {
                                        /// <summary>
                                        /// 获取或设置包含的行为列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("actions")]
                                        [System.Text.Json.Serialization.JsonPropertyName("actions")]
                                        public string[]? IncludedActions { get; set; }

                                        /// <summary>
                                        /// 获取或设置排除的行为列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("excluded_actions")]
                                        [System.Text.Json.Serialization.JsonPropertyName("excluded_actions")]
                                        public string[]? ExcludedActions { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置年龄定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("age")]
                                [System.Text.Json.Serialization.JsonPropertyName("age")]
                                public string[]? AgeRanges { get; set; }

                                /// <summary>
                                /// 获取或设置性别定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gender")]
                                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                                public string[]? GenderTypes { get; set; }

                                /// <summary>
                                /// 获取或设置学历定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("education")]
                                [System.Text.Json.Serialization.JsonPropertyName("education")]
                                public string[]? EducationTypes { get; set; }

                                /// <summary>
                                /// 获取或设置婚恋状态定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("relationship_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("relationship_status")]
                                public string[]? RelationshipStatuses { get; set; }

                                /// <summary>
                                /// 获取或设置用户付费习惯定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_paying_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_paying_type")]
                                public string[]? UserPayingTypes { get; set; }

                                /// <summary>
                                /// 获取或设置联网方式定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("network_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("network_type")]
                                public string[]? NetworkTypes { get; set; }

                                /// <summary>
                                /// 获取或设置移动运营商定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("network_operator")]
                                [System.Text.Json.Serialization.JsonPropertyName("network_operator")]
                                public string[]? NetworkOperatorTypes { get; set; }

                                /// <summary>
                                /// 获取或设置操作系统定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_os")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_os")]
                                public string[]? UserOSTypes { get; set; }

                                /// <summary>
                                /// 获取或设置移动设备价格定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("device_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("device_price")]
                                public string[]? DevicePriceTypes { get; set; }

                                /// <summary>
                                /// 获取或设置地理位置定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("geo_location")]
                                [System.Text.Json.Serialization.JsonPropertyName("geo_location")]
                                public Types.GeoLocation? GeoLocation { get; set; }

                                /// <summary>
                                /// 获取或设置微信广告行为定向。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wechat_ad_behavior")]
                                [System.Text.Json.Serialization.JsonPropertyName("wechat_ad_behavior")]
                                public Types.WechatAdBehavior? WechatAdBehavior { get; set; }

                                /// <summary>
                                /// 获取或设置包含的自定义人群 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("custom_audience")]
                                [System.Text.Json.Serialization.JsonPropertyName("custom_audience")]
                                public int[]? IncludedCustomAudienceIds { get; set; }

                                /// <summary>
                                /// 获取或设置排除的自定义人群 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("excluded_custom_audience")]
                                [System.Text.Json.Serialization.JsonPropertyName("excluded_custom_audience")]
                                public int[]? ExcludedCustomAudienceIds { get; set; }
                            }
                        }

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
                        /// 获取或设置广告组名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adgroup_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("adgroup_name")]
                        public string AdGroupName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置投放站点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_set")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_set")]
                        public string[] SiteList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标的物类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                        public string ProductType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标的物 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_refs_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_refs_id")]
                        public string? ProductRefId { get; set; }

                        /// <summary>
                        /// 获取或设置定向条件。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("targeting")]
                        [System.Text.Json.Serialization.JsonPropertyName("targeting")]
                        public Types.Target Target { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优化目标类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("optimization_goal")]
                        [System.Text.Json.Serialization.JsonPropertyName("optimization_goal")]
                        public string OptimizationGoalType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置出价方式类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("billing_event")]
                        [System.Text.Json.Serialization.JsonPropertyName("billing_event")]
                        public string BillingEventType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告出价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bid_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("bid_amount")]
                        public int BidAmount { get; set; }

                        /// <summary>
                        /// 获取或设置开始投放日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
                        public string BeginDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结束投放日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                        public string EndDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置投放时间段。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_series")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_series")]
                        public string TimeSeries { get; set; } = default!;

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
                }

                /// <summary>
                /// 获取或设置广告组列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.AdGroup[] AdGroupList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public CommonPagination Pagination { get; set; } = default!;
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
