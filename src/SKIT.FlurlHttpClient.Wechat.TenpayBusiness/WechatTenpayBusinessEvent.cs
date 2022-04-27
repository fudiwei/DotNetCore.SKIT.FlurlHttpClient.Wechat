using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 表示腾讯微企付 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatTenpayBusinessEvent
    {
        /// <summary>
        /// 获取或设置 API 版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("api_version")]
        [System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// 获取或设置通知 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_id")]
        [System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否是生产环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("live_mode")]
        public bool IsLiveMode { get; set; }

        /// <summary>
        /// 获取或设置之前回调通知失败的次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pending_webhooks")]
        [System.Text.Json.Serialization.JsonPropertyName("pending_webhooks")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int PendingWebhookTimes { get; set; }

        /// <summary>
        /// 获取或设置通知创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }

    /// <summary>
    /// 表示腾讯微企付 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatTenpayBusinessEvent<TEventContent> : WechatTenpayBusinessEvent
        where TEventContent : class, new()
    {
        /// <summary>
        /// 获取或设置通知内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_content")]
        [System.Text.Json.Serialization.JsonPropertyName("event_content")]
        public TEventContent EventContent { get; set; } = default!;
    }
}
