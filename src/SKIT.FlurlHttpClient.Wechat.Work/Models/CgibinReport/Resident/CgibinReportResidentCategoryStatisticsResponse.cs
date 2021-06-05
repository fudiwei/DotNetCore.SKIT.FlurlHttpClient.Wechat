using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/resident/category_statistic 接口的响应。</para>
    /// </summary>
    public class CgibinReportResidentCategoryStatisticsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data : CgibinReportPatrolCategoryStatisticsResponse.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dashboard_list")]
        [System.Text.Json.Serialization.JsonPropertyName("dashboard_list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
