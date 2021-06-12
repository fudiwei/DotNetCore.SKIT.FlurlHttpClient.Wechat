using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /adgroups/add 接口的请求。</para>
    /// </summary>
    public class AdGroupsAddRequest : WechatAdsRequest
    {
        public static class Types
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
                        public IList<string> LocationTypes { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置省市区县 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("regions")]
                        [System.Text.Json.Serialization.JsonPropertyName("regions")]
                        public IList<int>? RegionIds { get; set; }

                        /// <summary>
                        /// 获取或设置商圈 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_districts")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_districts")]
                        public IList<int>? BusinessDistrictIds { get; set; }

                        /// <summary>
                        /// 获取或设置自定义地理位置列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_locations")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_locations")]
                        public IList<Types.CustomLocation>? CustomLocations { get; set; }
                    }

                    public class WechatAdBehavior
                    {
                        /// <summary>
                        /// 获取或设置包含的行为列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actions")]
                        [System.Text.Json.Serialization.JsonPropertyName("actions")]
                        public IList<string>? IncludedActions { get; set; }

                        /// <summary>
                        /// 获取或设置排除的行为列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("excluded_actions")]
                        [System.Text.Json.Serialization.JsonPropertyName("excluded_actions")]
                        public IList<string>? ExcludedActions { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置年龄定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("age")]
                [System.Text.Json.Serialization.JsonPropertyName("age")]
                public IList<string>? AgeRanges { get; set; }

                /// <summary>
                /// 获取或设置性别定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                public IList<string>? GenderTypes { get; set; }

                /// <summary>
                /// 获取或设置学历定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("education")]
                [System.Text.Json.Serialization.JsonPropertyName("education")]
                public IList<string>? EducationTypes { get; set; }

                /// <summary>
                /// 获取或设置婚恋状态定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("relationship_status")]
                [System.Text.Json.Serialization.JsonPropertyName("relationship_status")]
                public IList<string>? RelationshipStatuses { get; set; }

                /// <summary>
                /// 获取或设置用户付费习惯定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_paying_type")]
                [System.Text.Json.Serialization.JsonPropertyName("user_paying_type")]
                public IList<string>? UserPayingTypes { get; set; }

                /// <summary>
                /// 获取或设置联网方式定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("network_type")]
                [System.Text.Json.Serialization.JsonPropertyName("network_type")]
                public IList<string>? NetworkTypes { get; set; }

                /// <summary>
                /// 获取或设置移动运营商定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("network_operator")]
                [System.Text.Json.Serialization.JsonPropertyName("network_operator")]
                public IList<string>? NetworkOperatorTypes { get; set; }

                /// <summary>
                /// 获取或设置操作系统定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_os")]
                [System.Text.Json.Serialization.JsonPropertyName("user_os")]
                public IList<string>? UserOSTypes { get; set; }

                /// <summary>
                /// 获取或设置移动设备价格定向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_price")]
                [System.Text.Json.Serialization.JsonPropertyName("device_price")]
                public IList<string>? DevicePriceTypes { get; set; }

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
                public IList<int>? IncludedCustomAudienceIds { get; set; }

                /// <summary>
                /// 获取或设置排除的自定义人群 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("excluded_custom_audience")]
                [System.Text.Json.Serialization.JsonPropertyName("excluded_custom_audience")]
                public IList<int>? ExcludedCustomAudienceIds { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推广计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_id")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
        public long CampaignId { get; set; }

        /// <summary>
        /// 获取或设置广告组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adgroup_name")]
        [System.Text.Json.Serialization.JsonPropertyName("adgroup_name")]
        public string AdGroupName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置投放站点列表。
        /// <para>默认值：["SITE_SET_WECHAT"]</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site_set")]
        [System.Text.Json.Serialization.JsonPropertyName("site_set")]
        public IList<string> SiteList { get; set; } = new List<string>() { "SITE_SET_WECHAT" };

        /// <summary>
        /// 获取或设置标的物类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public string ProductType { get; set; } = string.Empty;

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
        public Types.Target Target { get; set; } = new Types.Target();

        /// <summary>
        /// 获取或设置优化目标类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("optimization_goal")]
        [System.Text.Json.Serialization.JsonPropertyName("optimization_goal")]
        public string OptimizationGoalType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置出价方式类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billing_event")]
        [System.Text.Json.Serialization.JsonPropertyName("billing_event")]
        public string BillingEventType { get; set; } = string.Empty;

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
        public string BeginDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束投放日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = string.Empty;

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
