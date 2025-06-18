namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/del 接口的请求。</para>
    /// </summary>
    public class CgibinOAScheduleDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string ScheduleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("op_mode")]
        public int? OperateMode { get; set; }

        /// <summary>
        /// 获取或设置操作起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("op_start_time")]
        public long? OperateStartTimestamp { get; set; }
    }
}
