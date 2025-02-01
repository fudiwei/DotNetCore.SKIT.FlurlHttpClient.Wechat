namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.advanced_api_expired 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100269 ]]>
    /// </para>
    /// </summary>
    public class AdvancedApiExpiredEvent : AdvancedApiTrialExpiredEvent
    {
        public static class Types
        {
            public class ChatArchiveApi
            {
                /// <summary>
                /// 获取或设置到期的账号版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Edition")]
                [System.Text.Json.Serialization.JsonPropertyName("Edition")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("Edition")]
                public int Edition { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会话内容数据接口相关信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChatArchiveApi")]
        [System.Text.Json.Serialization.JsonPropertyName("ChatArchiveApi")]
        [System.Xml.Serialization.XmlElement("ChatArchiveApi")]
        public Types.ChatArchiveApi ChatArchiveApi { get; set; } = default!;
    }
}
