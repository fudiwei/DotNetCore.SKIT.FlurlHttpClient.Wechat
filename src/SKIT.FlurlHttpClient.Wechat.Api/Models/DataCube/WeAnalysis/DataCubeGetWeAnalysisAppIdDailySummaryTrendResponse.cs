using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappiddailysummarytrend 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdDailySummaryTrendResponse : WechatApiResponse
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
                public string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置累计用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visit_total")]
                [System.Text.Json.Serialization.JsonPropertyName("visit_total")]
                public int VisitTotal { get; set; }

                /// <summary>
                /// 获取或设置转发次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("share_pv")]
                public int SharePV { get; set; }

                /// <summary>
                /// 获取或设置转发人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("share_uv")]
                public int ShareUV { get; set; }
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
