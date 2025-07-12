namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_user_info_get 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/channels_ec_vip_user_info_get.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECVipUserInfoGetEvent : WechatApiEvent
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
