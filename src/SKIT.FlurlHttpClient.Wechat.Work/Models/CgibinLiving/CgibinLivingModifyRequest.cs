namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/modify 接口的请求。</para>
    /// </summary>
    public class CgibinLivingModifyRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Attendee : CgibinMeetingCreateRequest.Types.Attendee
            {
            }
        }

        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("livingid")]
        [System.Text.Json.Serialization.JsonPropertyName("livingid")]
        public string LivingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置直播标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("theme")]
        [System.Text.Json.Serialization.JsonPropertyName("theme")]
        public string? Theme { get; set; }

        /// <summary>
        /// 获取或设置直播开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_start")]
        [System.Text.Json.Serialization.JsonPropertyName("living_start")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置直播持续时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("living_duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 获取或设置直播类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置直播简介。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置直播开始前多久提醒（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remind_time")]
        [System.Text.Json.Serialization.JsonPropertyName("remind_time")]
        public int? RemindBeforeEventTime { get; set; }
    }
}
