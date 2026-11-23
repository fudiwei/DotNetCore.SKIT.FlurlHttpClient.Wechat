namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.betaapp_personal_authorization_apply_event" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/register-management/fast-regist-beta/api_fastnormalizebetaweapp.html ]]>
    /// </para>
    /// </summary>
    public class BetaAppPersonalAuthorizationApplyEvent : WechatApiEvent
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
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置操作时间字符串（格式：yyyy-MM-dd HH:mm）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operation_time")]
                [System.Text.Json.Serialization.JsonPropertyName("operation_time")]
                [System.Xml.Serialization.XmlElement("operation_time")]
                public string? OperateTimeString { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplyPersonalAuthorizationInfoNotify")]
        [System.Text.Json.Serialization.JsonPropertyName("ApplyPersonalAuthorizationInfoNotify")]
        [System.Xml.Serialization.XmlElement("ApplyPersonalAuthorizationInfoNotify")]
        public Types.EventData? EventData { get; set; }
    }
}
