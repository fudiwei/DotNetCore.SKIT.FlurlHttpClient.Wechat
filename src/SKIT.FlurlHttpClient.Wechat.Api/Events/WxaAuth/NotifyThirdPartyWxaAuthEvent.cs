namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.notify_3rd_wxa_auth 事件的数据。</para>
    /// <para>https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/weapp-wxverify/secwxaapi_wxaauth.html </para>
    /// </summary>
    public class NotifyThirdPartyWxaAuthEvent : WechatApiEvent
    {
        public static class Types
        {
            public class DispatchInfo
            {
                /// <summary>
                /// 获取或设置审核机构名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("provider")]
                [System.Text.Json.Serialization.JsonPropertyName("provider")]
                [System.Xml.Serialization.XmlElement("provider")]
                public string Provider { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核机构联系方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact")]
                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                [System.Xml.Serialization.XmlElement("contact")]
                public string Contact { get; set; } = default!;

                /// <summary>
                /// 获取或设置派单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dispatch_time")]
                [System.Text.Json.Serialization.JsonPropertyName("dispatch_time")]
                [System.Xml.Serialization.XmlElement("dispatch_time")]
                public long DispatchTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        [System.Xml.Serialization.XmlElement("appid")]
        public string AuthorizerAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        [System.Xml.Serialization.XmlElement("taskid")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_status")]
        [System.Text.Json.Serialization.JsonPropertyName("task_status")]
        [System.Xml.Serialization.XmlElement("task_status")]
        public int TaskStatus { get; set; }

        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_status")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_status")]
        [System.Xml.Serialization.XmlElement("apply_status")]
        public int ApplyStatus { get; set; }

        /// <summary>
        /// 获取或设置提醒消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        [System.Xml.Serialization.XmlElement("message", IsNullable = true)]
        public string? Message { get; set; }

        /// <summary>
        /// 获取或设置派单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispatch_info")]
        [System.Text.Json.Serialization.JsonPropertyName("dispatch_info")]
        [System.Xml.Serialization.XmlElement("dispatch_info", IsNullable = true)]
        public Types.DispatchInfo? DispatchInfo { get; set; }
    }
}
