namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_user_auto_add 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/channels_ec_vip_user_auto_add.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECVipUserAutoAddEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                [System.Xml.Serialization.XmlElement("shop_appid")]
                public string ShopAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户会员身份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                [System.Xml.Serialization.XmlElement("identity")]
                public string Identity { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户会员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outer_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("outer_userid")]
                [System.Xml.Serialization.XmlElement("outer_userid", IsNullable = true)]
                public string? OutUserId { get; set; }

                /// <summary>
                /// 获取或设置关联成功时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_time")]
                [System.Text.Json.Serialization.JsonPropertyName("add_time")]
                [System.Xml.Serialization.XmlElement("add_time")]
                public long AddTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        [System.Xml.Serialization.XmlElement("info")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
