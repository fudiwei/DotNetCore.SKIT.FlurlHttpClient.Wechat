namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.betaapp_verify_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/verify_beta_Mini_Programs/getmpadminauth.html </para>
    /// </summary>
    public class BetaAppVerifyEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置小程序的 AppId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("appid")]
                public string MiniProgramAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置公众号的 AppId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("mp_appid")]
                public string MediaPlatformAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作时间字符串（格式：yyyy-MM-dd HH:mm）。
                /// </summary>
                [System.Xml.Serialization.XmlElement("operation_time")]
                public string OperateTimeString { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [System.Xml.Serialization.XmlElement("status")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ApplyAuthorizationInfoNoitfy")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
