namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 MINIPROGRAMPAGE 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/customer-message/receive.html ]]>
    /// </para>
    /// </summary>
    public class MiniProgramPageMessageEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppId")]
        [System.Text.Json.Serialization.JsonPropertyName("AppId")]
        [System.Xml.Serialization.XmlElement("AppId")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Title")]
        [System.Text.Json.Serialization.JsonPropertyName("Title")]
        [System.Xml.Serialization.XmlElement("Title")]
        public string MiniProgramTitle { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PagePath")]
        [System.Text.Json.Serialization.JsonPropertyName("PagePath")]
        [System.Xml.Serialization.XmlElement("PagePath")]
        public string MiniProgramPagePath { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序缩略图 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ThumbUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("ThumbUrl")]
        [System.Xml.Serialization.XmlElement("ThumbUrl")]
        public string MiniProgramThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序缩略图 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ThumbMediaId")]
        [System.Text.Json.Serialization.JsonPropertyName("ThumbMediaId")]
        [System.Xml.Serialization.XmlElement("ThumbMediaId", IsNullable = true)]
        public string? MiniProgramThumbnailMediaId { get; set; }
    }
}
