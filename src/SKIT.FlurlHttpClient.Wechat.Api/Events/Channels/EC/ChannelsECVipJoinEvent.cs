namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_join 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/callback/member/user_join_vip.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECVipJoinEvent : WechatApiEvent
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                [System.Xml.Serialization.XmlElement("phone_number")]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置加入时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("join_time")]
                [System.Text.Json.Serialization.JsonPropertyName("join_time")]
                [System.Xml.Serialization.XmlElement("join_time")]
                public long JoinTimestamp { get; set; }
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
