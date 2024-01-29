namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.minigame_coin_deliver_completed 事件的数据。</para>
    /// <para>https://docs.qq.com/doc/DVVZZdHFsYkttYmxl </para>
    /// </summary>
    public class MiniGameCoinDeliverCompletedEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置携带的具体内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Payload")]
                [System.Text.Json.Serialization.JsonPropertyName("Payload")]
                [System.Xml.Serialization.XmlElement("Payload")]
                public string Payload { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付签名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PayEventSig")]
                [System.Text.Json.Serialization.JsonPropertyName("PayEventSig")]
                [System.Xml.Serialization.XmlElement("PayEventSig")]
                public string PaySign { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否是模拟数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("IsMock")]
                [System.Text.Json.Serialization.JsonPropertyName("IsMock")]
                [System.Xml.Serialization.XmlElement("IsMock")]
                public bool IsMock { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MiniGame")]
        [System.Text.Json.Serialization.JsonPropertyName("MiniGame")]
        [System.Xml.Serialization.XmlElement("MiniGame")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
