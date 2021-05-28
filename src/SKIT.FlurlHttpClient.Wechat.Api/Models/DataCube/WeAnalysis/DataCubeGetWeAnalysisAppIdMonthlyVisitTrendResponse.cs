using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappidmonthlyvisittrend 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdMonthlyVisitTrendResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : DataCubeGetWeAnalysisAppIdDailyVisitTrendResponse.Types.Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyyMM）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public override string RefDateString { get; set; } = default!;
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
