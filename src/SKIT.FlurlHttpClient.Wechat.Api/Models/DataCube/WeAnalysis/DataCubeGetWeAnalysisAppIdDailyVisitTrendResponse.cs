using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappiddailyvisittrend 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdDailyVisitTrendResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public virtual string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置打开次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("session_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("session_cnt")]
                public int SessionCount { get; set; }

                /// <summary>
                /// 获取或设置访问次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visit_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("visit_pv")]
                public int VisitPV { get; set; }

                /// <summary>
                /// 获取或设置访问人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visit_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("visit_uv")]
                public int VisitUV { get; set; }

                /// <summary>
                /// 获取或设置新用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visit_uv_new")]
                [System.Text.Json.Serialization.JsonPropertyName("visit_uv_new")]
                public int NewVisitUV { get; set; }

                /// <summary>
                /// 获取或设置人均停留时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stay_time_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("stay_time_uv")]
                public double StayTimePerUV { get; set; }

                /// <summary>
                /// 获取或设置次均停留时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stay_time_session")]
                [System.Text.Json.Serialization.JsonPropertyName("stay_time_session")]
                public double StayTimePerSession { get; set; }

                /// <summary>
                /// 获取或设置平均访问深度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visit_depth")]
                [System.Text.Json.Serialization.JsonPropertyName("visit_depth")]
                public double VisitDepth { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
