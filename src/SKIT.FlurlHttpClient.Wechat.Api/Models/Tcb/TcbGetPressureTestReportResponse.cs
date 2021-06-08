using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getpressuretestreport 接口的响应。</para>
    /// </summary>
    public class TcbGetPressureTestReportResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Report
            {
                public static class Types
                {
                    public class Network
                    {
                        public static class Types
                        {
                            public class TopTimeCost
                            {
                                /// <summary>
                                /// 获取或设置请求耗时（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_cost")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_cost")]
                                public int CostTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置网络请求路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string Path { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置请求平均耗时（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aver_time_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("aver_time_cost")]
                        public int AverageCostTime { get; set; }

                        /// <summary>
                        /// 获取或设置请求最大耗时（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_time_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_time_cost")]
                        public int MaxCostTime { get; set; }

                        /// <summary>
                        /// 获取或设置共请求了多少多次。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_request_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_request_cnt")]
                        public int TotalRequestCount { get; set; }

                        /// <summary>
                        /// 获取或设置请求成功率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("succ_percent")]
                        [System.Text.Json.Serialization.JsonPropertyName("succ_percent")]
                        public int SuccessPercent { get; set; }

                        /// <summary>
                        /// 获取或设置 TOP 耗时的请求。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("top_time_cost_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("top_time_cost_list")]
                        public Types.TopTimeCost[] TopTimeCostList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置超过 800ms 的请求数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("over_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("over_count")]
                        public int OvertimeCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置压测 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pressure_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pressure_id")]
                public int PressureId { get; set; }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_url")]
                [System.Text.Json.Serialization.JsonPropertyName("task_url")]
                public string TaskPagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置压测时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("run_time")]
                [System.Text.Json.Serialization.JsonPropertyName("run_time")]
                public int RunTime { get; set; }

                /// <summary>
                /// 获取或设置打开页面的白页率。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("blankpage_pencent")]
                [System.Text.Json.Serialization.JsonPropertyName("blankpage_pencent")]
                public int BlankPagePencent { get; set; }

                /// <summary>
                /// 获取或设置打开页面的平均耗时（单位：毫秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aver_time_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("aver_time_cost")]
                public int AverageCostTime { get; set; }

                /// <summary>
                /// 获取或设置打开页面的最大耗时（单位：毫秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_time_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("max_time_cost")]
                public int MaxCostTime { get; set; }

                /// <summary>
                /// 获取或设置共打开了多少次该页面。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_launch_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("total_launch_cnt")]
                public int TotalLaunchCount { get; set; }

                /// <summary>
                /// 获取或设置共发起多少次网络请求。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_request_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("total_request_cnt")]
                public int TotalRequestCount { get; set; }

                /// <summary>
                /// 获取或设置各网络请求的统计列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("network_list")]
                [System.Text.Json.Serialization.JsonPropertyName("network_list")]
                public Types.Network[]? NetworkList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置压测报告信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report")]
        [System.Text.Json.Serialization.JsonPropertyName("report")]
        public Types.Report Report { get; set; } = default!;
    }
}
