namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.secvod_upload_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/mini-drama/mini_drama.html#_7-1-%E5%AA%92%E8%B5%84%E4%B8%8A%E4%BC%A0%E5%AE%8C%E6%88%90%E4%BA%8B%E4%BB%B6%20SecVod </para>
    /// </summary>
    public class SecVodUploadEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                [System.Xml.Serialization.XmlElement("media_id")]
                public string MediaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置来源上下文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_context")]
                [System.Text.Json.Serialization.JsonPropertyName("source_context")]
                [System.Xml.Serialization.XmlElement("source_context")]
                public string SourceContext { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                [System.Xml.Serialization.XmlElement("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                [System.Xml.Serialization.XmlElement("errmsg", IsNullable = true)]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_event")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_event")]
        [System.Xml.Serialization.XmlElement("upload_event")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
