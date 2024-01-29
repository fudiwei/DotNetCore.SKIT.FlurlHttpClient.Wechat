namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_grade_info_update 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/vip/callback/member/usergrade_update.html </para>
    /// </summary>
    public class ChannelsECVipGradeInfoUpgradeEvent : WechatApiEvent
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置会员等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grade")]
                [System.Text.Json.Serialization.JsonPropertyName("grade")]
                [System.Xml.Serialization.XmlElement("grade")]
                public int Grade { get; set; }

                /// <summary>
                /// 获取或设置经验值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("experience_value")]
                [System.Text.Json.Serialization.JsonPropertyName("experience_value")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("experience_value")]
                public int ExperienceValue { get; set; }
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
