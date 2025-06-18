namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/punch_correction 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinPunchCorrectionRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置应打卡日期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_date_time")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_date_time")]
        public long ScheduleDateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置应打卡时间点偏移秒数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_checkin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_checkin_time")]
        public int? ScheduleCheckinTime { get; set; }

        /// <summary>
        /// 获取或设置实际打卡时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("checkin_time")]
        public long CheckinTimestamp { get; set; }

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
