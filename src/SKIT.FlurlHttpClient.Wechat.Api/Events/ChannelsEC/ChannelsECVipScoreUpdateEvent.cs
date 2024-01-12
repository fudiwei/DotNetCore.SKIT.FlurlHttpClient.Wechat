namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_score_update 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/vip/callback/score/user_score_update.html </para>
    /// </summary>
    public class ChannelsECVipScoreUpdateEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
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
                /// 获取或设置当前积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score")]
                [System.Text.Json.Serialization.JsonPropertyName("score")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("score")]
                public int Score { get; set; }

                /// <summary>
                /// 获取或设置本次改动积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delta_score")]
                [System.Text.Json.Serialization.JsonPropertyName("delta_score")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("delta_score")]
                public int DeltaScore { get; set; }

                /// <summary>
                /// 获取或设置流水类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow_type")]
                [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
                [System.Xml.Serialization.XmlElement("flow_type")]
                public int FlowType { get; set; }
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
