using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /async_tasks/add 接口的请求。</para>
    /// </summary>
    public class AsyncTasksAddRequest : WechatAdsRequest
    {
        public static class Types
        {
            public class Specification
            {
                public static class Types
                {
                    public class AdGroupHourlyReportSpec
                    {
                        /// <summary>
                        /// 获取或设置查询日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = string.Empty;
                    }

                    public class AdGroupDailyReportSpec : AdGroupHourlyReportSpec
                    {
                    }

                    public class WechatAdvertisingDataSpec
                    {
                        public static class Types
                        {
                            public sealed class TimeRange
                            {
                                /// <summary>
                                /// 获取或设置开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("begin_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                                public long BeginTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public long EndTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置查询时间范围）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_modified_time_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_modified_time_range")]
                        public Types.TimeRange TimeRange { get; set; } = new Types.TimeRange();

                        /// <summary>
                        /// 获取或设置查询字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fields")]
                        [System.Text.Json.Serialization.JsonPropertyName("fields")]
                        public IList<string> FieldList { get; set; } = new List<string>();
                    }

                    public class POIHourlyReportSpec : AdGroupHourlyReportSpec
                    {
                    }
                }

                /// <summary>
                /// 获取或设置广告组小时报表查询条件所需条件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_type_adgroup_hourly_report_spec")]
                [System.Text.Json.Serialization.JsonPropertyName("task_type_adgroup_hourly_report_spec")]
                public Types.AdGroupHourlyReportSpec? AdGroupHourlyReportSpec { get; set; }

                /// <summary>
                /// 获取或设置广告组天报表查询条件所需条件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_type_adgroup_daily_report_spec")]
                [System.Text.Json.Serialization.JsonPropertyName("task_type_adgroup_daily_report_spec")]
                public Types.AdGroupDailyReportSpec? AdGroupDailyReportSpec { get; set; }

                /// <summary>
                /// 获取或设置微信广告数据查询条件所需条件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_type_wechat_advertising_data_spec")]
                [System.Text.Json.Serialization.JsonPropertyName("task_type_wechat_advertising_data_spec")]
                public Types.WechatAdvertisingDataSpec? WechatAdvertisingDataSpec { get; set; }
                
                /// <summary>
                /// 获取或设置微信门店小时报表查询条件所需条件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_type_poi_hourly_report_spec")]
                [System.Text.Json.Serialization.JsonPropertyName("task_type_poi_hourly_report_spec")]
                public Types.POIHourlyReportSpec? POIHourlyReportSpec { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_name")]
        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string TaskName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_type")]
        [System.Text.Json.Serialization.JsonPropertyName("task_type")]
        public string TaskType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务所需条件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_spec")]
        [System.Text.Json.Serialization.JsonPropertyName("task_spec")]
        public Types.Specification TaskSpecification { get; set; } = new Types.Specification();
    }
}
