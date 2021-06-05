using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/get_user_status 接口的响应。</para>
    /// </summary>
    public class CgibinReportPatrolGetUserStatusResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置办理中数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("processing")]
        [System.Text.Json.Serialization.JsonPropertyName("processing")]
        public int ProcessingCount { get; set; }

        /// <summary>
        /// 获取或设置今日上报数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("added_today")]
        [System.Text.Json.Serialization.JsonPropertyName("added_today")]
        public int TodayAddedCount { get; set; }

        /// <summary>
        /// 获取或设置今日办结数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("solved_today")]
        [System.Text.Json.Serialization.JsonPropertyName("solved_today")]
        public int TodaySolvedCount { get; set; }
    }
}
