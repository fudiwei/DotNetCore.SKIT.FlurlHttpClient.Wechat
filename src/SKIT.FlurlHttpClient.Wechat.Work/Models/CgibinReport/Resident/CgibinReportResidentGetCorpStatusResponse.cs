namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/resident/get_corp_status 接口的响应。</para>
    /// </summary>
    public class CgibinReportResidentGetCorpStatusResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置待受理数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pending")]
        [System.Text.Json.Serialization.JsonPropertyName("pending")]
        public int PendingCount { get; set; }

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

        /// <summary>
        /// 获取或设置累计上报数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_case")]
        [System.Text.Json.Serialization.JsonPropertyName("total_case")]
        public int TotalAddedCount { get; set; }

        /// <summary>
        /// 获取或设置累计受理数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_accepted")]
        [System.Text.Json.Serialization.JsonPropertyName("total_accepted")]
        public int TotalAcceptedCount { get; set; }

        /// <summary>
        /// 获取或设置累计办结数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_solved")]
        [System.Text.Json.Serialization.JsonPropertyName("total_solved")]
        public int TotalSolvedCount { get; set; }
    }
}
