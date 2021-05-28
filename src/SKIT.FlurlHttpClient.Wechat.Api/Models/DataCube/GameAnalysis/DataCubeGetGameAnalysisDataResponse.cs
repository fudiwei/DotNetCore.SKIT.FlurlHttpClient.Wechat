using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getgameanalysisdata 接口的响应。</para>
    /// </summary>
    public class DataCubeGetGameAnalysisDataResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class GroupDimension
                    {
                        /// <summary>
                        /// 获取或设置维度标签。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("label")]
                        [System.Text.Json.Serialization.JsonPropertyName("label")]
                        public string Label { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置维度取值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置数据时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置数据时间标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_label")]
                [System.Text.Json.Serialization.JsonPropertyName("time_label")]
                public string TimeLabel { get; set; } = default!;

                /// <summary>
                /// 获取或设置维度取值分布列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_dimension_list")]
                [System.Text.Json.Serialization.JsonPropertyName("group_dimension_list")]
                public Types.GroupDimension[]? GroupDimensionList { get; set; }

                /// <summary>
                /// 获取或设置指标数值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("metric_value")]
                [System.Text.Json.Serialization.JsonPropertyName("metric_value")]
                public double MetricValue { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
