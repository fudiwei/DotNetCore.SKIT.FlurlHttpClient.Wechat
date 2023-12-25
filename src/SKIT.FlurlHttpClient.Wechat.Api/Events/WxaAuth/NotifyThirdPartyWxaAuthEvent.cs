namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.notify_3rd_wxa_auth 事件的数据。</para>
    /// <para>https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/weapp-wxverify/secwxaapi_wxaauth.html </para>
    /// </summary>
    public class NotifyThirdPartyWxaAuthEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class DispatchInfo
            {
                /// <summary>
                /// 获取或设置审核机构名称。
                /// </summary>
                [System.Xml.Serialization.XmlElement("provider")]
                public string Provider { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核机构联系方式。
                /// </summary>
                [System.Xml.Serialization.XmlElement("contact")]
                public string Contact { get; set; } = default!;

                /// <summary>
                /// 获取或设置派单时间戳。
                /// </summary>
                [System.Xml.Serialization.XmlElement("dispatch_time")]
                public long DispatchTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appid")]
        public string AuthorizerAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证任务 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("taskid")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证任务状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("task_status")]
        public int TaskStatus { get; set; }

        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("apply_status")]
        public int ApplyStatus { get; set; }

        /// <summary>
        /// 获取或设置提醒消息内容。
        /// </summary>
        [System.Xml.Serialization.XmlElement("message", IsNullable = true)]
        public string? Message { get; set; }

        /// <summary>
        /// 获取或设置派单信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("dispatch_info", IsNullable = true)]
        public Types.DispatchInfo? DispatchInfo { get; set; }
    }
}
