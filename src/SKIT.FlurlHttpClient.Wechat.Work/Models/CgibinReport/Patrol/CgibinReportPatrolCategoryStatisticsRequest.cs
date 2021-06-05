using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/category_statistic 接口的请求。</para>
    /// </summary>
    public class CgibinReportPatrolCategoryStatisticsRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = string.Empty;
    }
}
