namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.miniprogram_sharer_action 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/API/sharer/share_attribute.html </para>
    /// </summary>
    public class MiniProgramSharerActionsEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Promoter
            {
                /// <summary>
                /// 获取或设置推广员昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_nickname")]
                [System.Xml.Serialization.XmlElement("finder_nickname", IsNullable = true)]
                public string? FinderNickname { get; set; }

                /// <summary>
                /// 获取或设置推广员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
                [System.Xml.Serialization.XmlElement("promoter_id", IsNullable = true)]
                public string? PromoterId { get; set; }

                /// <summary>
                /// 获取或设置推广员 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_openid")]
                [System.Xml.Serialization.XmlElement("promoter_openid", IsNullable = true)]
                public string? PromoterOpenId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Xml.Serialization.XmlElement("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置分享员 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        [System.Xml.Serialization.XmlElement("openid")]
        public string SharerOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置分享者的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter")]
        [System.Xml.Serialization.XmlElement("promoter")]
        public Types.Promoter Promoter { get; set; } = default!;
    }
}
