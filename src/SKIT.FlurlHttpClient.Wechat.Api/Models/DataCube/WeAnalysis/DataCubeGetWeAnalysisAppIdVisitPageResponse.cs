using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappidvisitpage 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdVisitPageResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_path")]
                [System.Text.Json.Serialization.JsonPropertyName("page_path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置访问次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_visit_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("page_visit_pv")]
                public int PageVisitPV { get; set; }

                /// <summary>
                /// 获取或设置访问人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_visit_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("page_visit_uv")]
                public int PageVisitUV { get; set; }

                /// <summary>
                /// 获取或设置次均停留时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_staytime_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("page_staytime_pv")]
                public double PageStayTimePerPV { get; set; }

                /// <summary>
                /// 获取或设置进入页次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entrypage_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("entrypage_pv")]
                public int EntryPagePV { get; set; }

                /// <summary>
                /// 获取或设置退出页次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exitpage_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("exitpage_pv")]
                public int ExitPagePV { get; set; }

                /// <summary>
                /// 获取或设置转发次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_share_pv")]
                [System.Text.Json.Serialization.JsonPropertyName("page_share_pv")]
                public int PageSharePV { get; set; }

                /// <summary>
                /// 获取或设置转发人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_share_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("page_share_uv")]
                public int PageShareUV { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据的日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_date")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
        public virtual string RefDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户访问分布数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
