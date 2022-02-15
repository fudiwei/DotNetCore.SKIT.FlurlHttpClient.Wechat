using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getgameanalysisdata 接口的请求。</para>
    /// </summary>
    public class DataCubeGetGameAnalysisDataRequest : WechatApiRequest, IMapResponse<DataCubeGetGameAnalysisDataRequest, DataCubeGetGameAnalysisDataResponse>
    {
        public static class Types
        {
            public class Fitler
            {
                /// <summary>
                /// 获取或设置维度 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dimension")]
                [System.Text.Json.Serialization.JsonPropertyName("dimension")]
                public string Dimension { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置维度的取值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置指标 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metric")]
        [System.Text.Json.Serialization.JsonPropertyName("metric")]
        public string Metric { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置时间粒度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("granularity")]
        [System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public int Granularity { get; set; }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置维度筛选列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_list")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_list")]
        public IList<Types.Fitler>? FitlerList { get; set; }

        /// <summary>
        /// 获取或设置维度分组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_list")]
        public IList<string>? GroupList { get; set; }
    }
}
