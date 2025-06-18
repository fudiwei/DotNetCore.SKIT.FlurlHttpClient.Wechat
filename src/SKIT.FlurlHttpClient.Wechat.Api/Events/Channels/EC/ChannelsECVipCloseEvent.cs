namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_close 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/callback/member/user_join_vip.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECVipCloseEvent : WechatApiEvent
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置注销时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_time")]
                [System.Text.Json.Serialization.JsonPropertyName("close_time")]
                [System.Xml.Serialization.XmlElement("close_time")]
                public long CloseTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        [System.Xml.Serialization.XmlElement("user_info")]
        public Types.User User { get; set; } = default!;
    }
}
