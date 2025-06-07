namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.betaapp_authorization_apply_event 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/verify_beta_Mini_Programs/getmpadminauth.html ]]>
    /// </para>
    /// </summary>
    public class BetaAppAuthorizationApplyEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                [System.Xml.Serialization.XmlElement("appid")]
                public string MiniProgramAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置公众号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mp_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("mp_appid")]
                [System.Xml.Serialization.XmlElement("mp_appid")]
                public string MediaPlatformAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作时间字符串（格式：yyyy-MM-dd HH:mm）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operation_time")]
                [System.Text.Json.Serialization.JsonPropertyName("operation_time")]
                [System.Xml.Serialization.XmlElement("operation_time")]
                public string OperateTimeString { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg")]
                [System.Text.Json.Serialization.JsonPropertyName("msg")]
                [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置授权成功后生成的 Ticket。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket")]
                [System.Xml.Serialization.XmlElement("ticket", IsNullable = true)]
                public string? Ticket { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplyAuthorizationInfoNoitfy")]
        [System.Text.Json.Serialization.JsonPropertyName("ApplyAuthorizationInfoNoitfy")]
        [System.Xml.Serialization.XmlElement("ApplyAuthorizationInfoNoitfy")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
